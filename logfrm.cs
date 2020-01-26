using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using SeatBooking.forms;
namespace SeatBooking
{
    public partial class logfrm :BaseForm 
    {
        public logfrm()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.img ;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //设置任务栏图标
            base.CapitionLogo= Properties.Resources.study;
            
        }
         
        //用户登录界面
        private userfrm userFrm = null;


        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 私有方法

        /// <summary>
        /// 检验学号是否正确
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        private bool CheckUserID(string userid)
        {
            Regex regex = new Regex(@"^[\d][\d]{11}$",RegexOptions.None );
            return regex.IsMatch(userid);
        }

        private string GetJson(logInfo log)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            return json.Serialize(log);
        }

        private CookieContainer Getcookie(string postJson, string url)
        {
            CookieContainer cookies = new CookieContainer();

            //创建http请求
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.CookieContainer = cookies;
            request.KeepAlive = true;
            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 Safari/537.36";
            request.ContentType = "text/plain";
            request.Accept = "application/json, text/plain, */*";

            //将序列化的参数字符串转为字节流
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postJson);
            request.ContentLength = bytes.Length;

            //将字节流写入请求流
            Stream stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
            
            //获取服务器响应拿到的cookies
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return cookies;
        }

        private string GetContent(CookieContainer cookie, string url)
        {
            string content = "";
            HttpWebRequest httprequest = (HttpWebRequest)HttpWebRequest.Create(url);
            httprequest.CookieContainer = cookie;
            //设置浏览器请求头的一些参数
            httprequest.Accept = "application/json, text/plain, */*";
            httprequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 Safari/537.36";
            httprequest.ContentType = "text/plain";
            httprequest.Method = "GET";

            //获取浏览器的响应
            HttpWebResponse response = (HttpWebResponse)httprequest.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    content = reader.ReadToEnd();
                }
            
            }
            return content;
        }

        private string MatchContent(string exp, string content)
        {
            string match = "";
            Regex regex = new Regex(exp, RegexOptions.None);
            match = regex.Match(content).ToString();
            return match;
        }
        #endregion

        private void logbtn_Click(object sender, EventArgs e)
        {
               //检验学号是否有错
            string userID = this.UserIDtxt.Text;
            string Userpwd=this .pwdtxt .Text;
            try
            {
                logInfo log = new logInfo(userID, Userpwd, "88839057e4cf4dd638d506fc6d5a74b6", "pUFSRNnNDBvXG7Tk"
               , "142", "lab4", "lab4", "js_xxx", "b1d4cc7a-382c-5a15-4c48-0af29b036f43", "fake");
                string json = GetJson(log);

                //获取Cookies
                CookieContainer Cookies = Getcookie(json, "https://jxnu.huitu.zhishulib.com/api/1/login");
                string content = GetContent(Cookies, "https://jxnu.huitu.zhishulib.com/Station/Station/getUnreadMessageCount?LAB_JSON=1");
                
                //判断是否登录成功
                Regex regex = new Regex("\"is_login\":[\\s]true",RegexOptions.None );

                if(regex .IsMatch (content ))
                {
                    Regex reg = new Regex("\"uid\":[\\s]\"(?<uid>[\\d]+?)\"",RegexOptions.None );
                    //记录用户登录时的ID
                    string UserID = reg.Match(content).Groups["uid"].Value;
                    if (userFrm == null || userFrm.IsDisposed)
                    {
                        userFrm = new userfrm();
                        userFrm.Cookie = Cookies;
                        userFrm.userID = UserID;
                        userFrm.Show();
                        this.RealHide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"登录失败");
                return;
            }
          
        }

    }

    //提交用户信息类
    class logInfo
    {
        public string login_name { get; set; }
        public string password { get; set; }
        public string code { get; set; }

        public string str { get; set; }
        public string org_id { get; set; }
        public string _ApplicationId { get; set; }

        public string _JavaScriptKey { get; set; }
        public string _ClientVersion { get; set; }
        public string _InstallationId { get; set; }

        public string _SessionToken { get; set; }

        public logInfo(string Logname, string password, string Code, string Str, string Org_id, string _appID, string _JSKey, string _ClientV, string _InstID, string SessToken)
        {
            this.login_name = Logname;
            this.password = password;
            this.code = Code;
            this.str = Str;
            this.org_id = Org_id;
            this._ApplicationId = _appID;
            this._JavaScriptKey = _JSKey;
            this._ClientVersion = _ClientV;
            this._InstallationId = _InstID;
            this._SessionToken = SessToken;
        }
    }
    
}
