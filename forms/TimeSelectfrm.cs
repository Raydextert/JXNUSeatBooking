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
using System.Threading;
namespace SeatBooking.forms
{ 

    public delegate string [] PostParamsEvthanlder();
    public partial class TimeSelectfrm : BaseForm
    {
        public TimeSelectfrm()
        {
            InitializeComponent();
            base.CapitionLogo = Properties.Resources.study;
        }

        private CookieContainer cookie = null;
        public CookieContainer Cookie { set { cookie = value; } }
        int timestamp = 0;
        //传递参数事件
        public event PostParamsEvthanlder PostParamEvt;

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //触发调用事件
                string[] postparams = PostParamEvt();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("beginTime", postparams[0]);
                dic.Add("duration", postparams[1]);
                dic.Add("seats%5B0%5D", postparams[2]);
                dic.Add("seatBookers%5B0%5D", postparams[3]);
                string postparam = "";
                foreach (KeyValuePair<string, string> key in dic)
                {
                    postparam += key.Key.ToString() + "=" + key.Value.ToString() + "&";
                }
                postparam = postparam.Substring(0, postparam.Length - 1);
                //倒计时
                int year = this.dateTimePicker1.Value.Year;
                int month = this.dateTimePicker1.Value.Month;
                int day = this.dateTimePicker1.Value.Day;
                int hour = Convert.ToInt32(this.Hour_selCmbx.SelectedItem.ToString());
                int minute = Convert.ToInt32(this.Minute_selCmbx.SelectedItem.ToString());
                int second = Convert.ToInt32(this.Second_selCmbx.SelectedItem.ToString());
                DateTime dt = new DateTime(year, month, day, hour, minute, second);
                //
                timestamp = Convert.ToInt32((dt - DateTime.Now).TotalSeconds);
                Thread thread = new Thread(() => { GetTimestamp(timestamp,postparam); });
                thread.Start();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
               return;
            }
          
        }

        #region 私有方法
        //初始化操作
        private void innit()
        {
            for (int i = 0; i < 24; i++)
            {
                this.Hour_selCmbx.Items.Add(i.ToString ());
            }
            for (int i = 0; i <60;i++ )
            {
                this.Minute_selCmbx.Items.Add(i.ToString ());
            }
            for (int i = 0; i < 60;i++)
            {
                this.Second_selCmbx.Items.Add(i);
            }
            //
            this.Hour_selCmbx.Text = this.Hour_selCmbx.Items[0].ToString();
            this.Minute_selCmbx.Text = this.Minute_selCmbx.Items[0].ToString();
            this.Second_selCmbx.Text = this.Second_selCmbx.Items[0].ToString();
        }

        //倒计时
        private void GetTimestamp(int time,string postparams)
        {
            try
            {

                if (time < 0)
                {
                    MessageBox.Show(string.Format("选择错误的时间")
                 , "系统提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    return;
                }
                while (time> 0)
                {
                   
                    if (this.TimeCounttxt.InvokeRequired)
                    {

                      this.TimeCounttxt.Invoke(new MethodInvoker(() => { this.TimeCounttxt.Text = string.Format("距离预约时间还剩{0:N4}小时", Convert .ToDouble (time)/3600); }));
                       
                    }
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    time--;
                }
                if (time== 0)
                {
                    if (this.TimeCounttxt.InvokeRequired)
                    {

                        this.TimeCounttxt.Invoke(new MethodInvoker(() => { this.TimeCounttxt.Text = string.Format("距离预约时间还剩{0:N4}小时", Convert.ToDouble(time) / 3600); }));

                    }
                    string result = GetBookInfo(postparams, "https://jxnu.huitu.zhishulib.com/Seat/Index/bookSeats?LAB_JSON=1");
                    Regex regex = new Regex("\"result\":[\\s]\"success\"", RegexOptions.None);
                    //如果预约成功则提示成功
                    if (regex.IsMatch(result))
                    {
                        MessageBox.Show(string.Format("预约成功")
                        , "提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("预约失败")
                       , "提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    }
                }
            }
            catch (Exception ex)
            {  
                //解决关闭主线程支线程再次调用出现调用线程不存在的异常
                return;
            }
        }

        private string GetBookInfo(string postparam, string url)
        {
            string content = "";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.KeepAlive = true;
            request.CookieContainer = cookie;
            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.117 Safari/537.36";
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            request.Accept = "application/json, text/plain, */*";

            //字符串参数转为字节流
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postparam);
            request.ContentLength = bytes.Length;

            //字节数组写入请求流
            Stream stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            //获取服务器响应
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s, System.Text.Encoding.UTF8))
                {

                    content = reader.ReadToEnd();
                }

            }
            return content;

        }
        //倒计时设计
        //private void timecount(int timestamp)
        //{
        //    if (timestamp < 0)
        //    {
        //        MessageBox.Show("选择时间错误");
        //        return;
        //    }
           
        //}
        #endregion
        private void TimeSelectfrm_Load(object sender, EventArgs e)
        {
            innit();
            this.TimeCounttxt.ReadOnly = true;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            //关闭并销毁窗体
            this.Close();
            this.Dispose();
        }

        private void NowBookingbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //触发调用事件
                string[] postparams = PostParamEvt();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("beginTime", postparams[0]);
                dic.Add("duration", postparams[1]);
                dic.Add("seats%5B0%5D", postparams[2]);
                dic.Add("seatBookers%5B0%5D", postparams[3]);
                string postparam = "";
                foreach (KeyValuePair<string, string> key in dic)
                {
                    postparam += key.Key.ToString() + "=" + key.Value.ToString() + "&";
                }
                postparam = postparam.Substring(0, postparam.Length - 1);
                string result= GetBookInfo(postparam, "https://jxnu.huitu.zhishulib.com/Seat/Index/bookSeats?LAB_JSON=1");
                Regex regex = new Regex("\"result\":[\\s]\"success\"", RegexOptions.None);
                //如果预约成功则提示成功
                if (regex.IsMatch(result))
                {
                    MessageBox.Show(string.Format("预约成功")
                    , "提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    MessageBox.Show(string.Format("预约失败")
                   , "提示", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
        }
    }
}
