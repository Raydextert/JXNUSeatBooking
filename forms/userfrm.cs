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
namespace SeatBooking.forms
{
    public partial class userfrm : BaseForm
    {
        public userfrm()
        {
            InitializeComponent();
            base.CapitionLogo = Properties.Resources.study;
        }

        private void userfrm_Load(object sender, EventArgs e)
        {
            //添加选择时段
            timesel();
            //预约逻辑：不超过22点只能预约当天，超过22点只能预约次日
            
            //if (DateTime.Now.Hour >= 22)
            //{
            //    this.UseDateCmbx.Items.Add(DateTime.Now.AddDays(1).Date.ToShortDateString());
            //}
            //else
            //{   
            //    this.UseDateCmbx.Items.Add(DateTime.Now.Date.ToShortDateString());
            //}
            //提供最长为十五天的预约时间
            for (int i = 0; i<2; i++)
            {
                this.UseDateCmbx.Items.Add(DateTime.Now.AddDays(i).Date.ToShortDateString());
            }
            this.UseDateCmbx.Text = this.UseDateCmbx.Items[0].ToString();
        }

        //获取cookie
        private CookieContainer cookie = null;
        public CookieContainer Cookie { set { cookie = value; } }
        public string userID { get; set; }
        //自习室座位
        Dictionary<string, string> Room_35 = null;
        Dictionary<string, string> Room_36 = null;
        Dictionary<string, string> Room_31 = null;
        Dictionary<string, string> Room_37 = null;
        private string seatID = "";
        private TimeSelectfrm timefrm = null;
        #region 私有方法
        private void timesel()
        {
            //任何时间段都可以预约
            for (int i = 7; i <= 19; i++)
            {
                this.StarttimeCmbx.Items.Add(i.ToString ());
            }

            this.RoomNOCmbx.Text = this.RoomNOCmbx.Items[0].ToString();
           
            if (this.StarttimeCmbx.Items.Count > 0)
            {
                this.StarttimeCmbx.Text = this.StarttimeCmbx.Items[0].ToString();
            }
        }

        private int GetTimestamp(DateTime dt)
        {
            DateTime start = new DateTime(1970, 1, 1, 8, 0, 0);
            int timestamp = Convert.ToInt32((dt - start).TotalSeconds);
            return timestamp;
        }

        //获取提交信息之后得到座位信息
        private string  SeatBooking(string postParams, string url)
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
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postParams);
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

        private string GetRoomNO(string Room_seleted)
        {
            string room_no = "";
            switch (Room_seleted)
            { 
                case "二楼北自习室(202)":
                    room_no = "35";//480
                    break;
                case"二楼南自习室(201)":
                    room_no = "36";//488
                    break;
                case"三楼南自习室(301)":
                    room_no = "31";//432
                    break;
                case"三楼北自习室(302)":
                    room_no = "37";//392
                    break;
            }
            return room_no;
        }

       
        //正则表达式获取所需内容
        private string MatchContent(string expression, string content)
        {
            string match = "";
            Regex regex = new Regex(expression, RegexOptions.None);
            match = regex.Match(content).ToString();
            return match;
        }

        //提取座位信息数据集合
        private MatchCollection Getseats(string expression, string content)
        {
            MatchCollection seats = null;

            Regex regex = new Regex(expression, RegexOptions.None);
            seats = regex.Matches(content);
            return seats;
        }

        //座位初始化
        private void SeatInit(string roomNO)
        {

            this.SeatNOCmbx.Items.Clear();
            string apppath = Application.StartupPath;
            switch (roomNO)
            {
              
                case "35":
                    string filepath_35 = apppath + "\\" + "35.txt";
                    Room_35 = new Dictionary<string, string>();
                    Room_35 = GetSeatdic(filepath_35);
                    foreach (KeyValuePair<string, string> key in Room_35)
                    {
                        this.SeatNOCmbx.Items.Add(key.Value);
                    }
                        break;
                case "36":
                    string filepath_36 = apppath + "\\" + "36.txt";
                    Room_36 = new Dictionary<string, string>();
                    Room_36 = GetSeatdic(filepath_36);
                    foreach (KeyValuePair<string, string> key in Room_36)
                    {
                        this.SeatNOCmbx.Items.Add(key.Value);
                    }
                    break;
                case "31":
                    string filepath_31 = apppath + "\\" + "31.txt";
                    Room_31 = new Dictionary<string, string>();
                    Room_31 = GetSeatdic(filepath_31);
                    foreach (KeyValuePair<string, string> key in Room_31)
                    {
                        this.SeatNOCmbx.Items.Add(key.Value);
                    }
                    break;
                case "37":
                    string filepath_37 = apppath + "\\" + "37.txt";
                    Room_37 = new Dictionary<string, string>();
                    Room_37 = GetSeatdic(filepath_37);
                    foreach (KeyValuePair<string, string> key in Room_37)
                    {
                        this.SeatNOCmbx.Items.Add(key.Value);
                    }
                    break;
            }
        }

        //传参函数
        public string[] Getparams()
        {   

            string[] param=new string [4];

            DateTime dt;
            int year = DateTime.Now.Year;
            int findex = this.UseDateCmbx.SelectedItem.ToString().IndexOf('/');
            int lindex= this .UseDateCmbx .SelectedItem .ToString ().LastIndexOf ('/');
            int month = Convert.ToInt32 (this.UseDateCmbx.SelectedItem.ToString().Substring(findex + 1, lindex - findex - 1));

            int day = Convert.ToInt32(this.UseDateCmbx.SelectedItem.ToString().Substring(lindex + 1));

            string select_item = this.StarttimeCmbx.SelectedItem.ToString();
            int select_hour = Convert.ToInt32(select_item.Split('时')[0]);


            dt = new DateTime(year, month, day, select_hour, 0, 0);
            int timestamp = GetTimestamp(dt);
            param[0] = timestamp.ToString();
            int duration=Convert .ToInt32 (this .DurationCmbx .SelectedItem.ToString ())*3600;
            param[1] = duration.ToString();
            //座位号
            param[2] = seatID;
            param[3] = userID;
            return param;
        }

        private void Write(string path, Dictionary<string, string> dic)
        {

            FileStream fs = new FileStream(path, FileMode.Create,FileAccess .Write );
            StreamWriter sw = new StreamWriter(fs);
            foreach (var d in dic)
            {
                sw.WriteLine(d.Key + "," + d.Value);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private Dictionary<string, string> GetSeatdic(string path)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var lines = line.Split(',');
                dic.Add(lines[0], lines[1]);
            }
            return dic;
        }
        #endregion

        private void StarttimeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DurationCmbx.Items.Clear();
            string selectItem = this.StarttimeCmbx.SelectedItem.ToString ();
            //转为数字时间
            int select_hour = Convert.ToInt32(selectItem .Split ('时')[0]);

            ////更新预约时段
            for (int i = 19; i >= select_hour; i--)
            {
                this.DurationCmbx.Items.Add(string.Format("{0:G}", 22 - i));
            }
          
        }

        private void DurationCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            //this.SeatNOCmbx.Items.Clear();
            //#region 提交预约参数
            ////座位预定参数传输
            ////formdata用字典传输
            ////当前时段预约获取当前座位信息次日预约时段则获取全部作为信息  
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //DateTime dt;
            //////判断当前时间是否大于22点
            ////if (DateTime.Now.Hour >= 22)
            ////{
            ////    int day = DateTime.Now.Day + 1;
            ////    int year = DateTime.Now.Year;
            ////    int month = DateTime.Now.Month;
            ////    string select_item = this.StarttimeCmbx.SelectedItem.ToString();
            ////    int select_hour = Convert.ToInt32(select_item.Split('时')[0]);
            ////    dt = new DateTime(year, month, day, select_hour, 0, 0);
            ////}
            ////else
            ////{
            ////    int day = DateTime.Now.Day;
            ////    int year = DateTime.Now.Year;
            ////    int month = DateTime.Now.Month;
            ////    string select_item = this.StarttimeCmbx.SelectedItem.ToString();
            ////    int select_hour = Convert.ToInt32(select_item.Split('时')[0]);
            ////    dt = new DateTime(year, month, day, select_hour, 0, 0);
            ////}
            ////转为时间戳
            //int year = DateTime.Now.Year;


            //int findex = this.UseDateCmbx.SelectedItem.ToString().IndexOf('/');
            //int lindex = this.UseDateCmbx.SelectedItem.ToString().LastIndexOf('/');
            //int month = Convert.ToInt32(this.UseDateCmbx.SelectedItem.ToString().Substring(findex + 1, lindex - findex - 1));

            //int day = Convert.ToInt32(this.UseDateCmbx.SelectedItem.ToString().Substring(lindex + 1));

            //string select_item = this.StarttimeCmbx.SelectedItem.ToString();
            //int select_hour = Convert.ToInt32(select_item.Split('时')[0]);


            //dt = new DateTime(year, month, day, select_hour, 0, 0);
            //int timestamp = GetTimestamp(dt);
            //int duration = Convert.ToInt32(this.DurationCmbx.SelectedItem.ToString()) * 3600;
            //int peopleNum = 1;
            //string room_no = GetRoomNO(this.RoomNOCmbx.Text);
            //dic.Add("beginTime", timestamp.ToString());
            //dic.Add("duration", duration.ToString());
            //dic.Add("num", peopleNum.ToString());
            //dic.Add("space_category%5Bcategory_id%5D", "591");
            //dic.Add("space_category%5Bcontent_id%5D", room_no);

            //string postparams = "";
            //foreach (KeyValuePair<string, string> key in dic)
            //{
            //    postparams += key.Key.ToString() + "=" + key.Value.ToString() + "&";
            //}
            //postparams = postparams.Substring(0, postparams.Length - 1);
            //#endregion
            //string seatinfo = SeatBooking(postparams, "https://jxnu.huitu.zhishulib.com/Seat/Index/searchSeats?LAB_JSON=1");

            //string regexp = "data[\\S\\s]*[\"]bestPairSeats";
            //string data = MatchContent(regexp, seatinfo);
            ////提取座位信息字符串
            //string pois = MatchContent("POIs[\\S\\s]*[\"]bestPairSeats", data);

            //string seatexp = "{[\\S\\s]+?}";
            //MatchCollection seats = Getseats(seatexp, pois);
            //Room_37 = new Dictionary<string, string>();
            ////应该将每个座位号都写入自带文件里面
            ////将座位号添加至控件
            //foreach (Match match in seats)
            //{
            //    string seatInfo = match.ToString();
            //    Regex title_reg=new Regex ("\"title\":[\\s]\"(?<titleID>[\\d]+?)\"",RegexOptions .None );
            //    string titleID = title_reg.Match(seatInfo).Groups["titleID"].Value;
            //    //提取座位号
            //    Regex regex = new Regex("\"id\":[\\s]\"(?<id>[\\d]+?)\"", RegexOptions.None);
            //    string id = regex.Match(seatInfo).Groups["id"].Value;
            //    Room_37.Add(id, titleID);
            //    #region 座位号码及当前状态
            //    ////0：可选 1：系统推荐 2：选中 3：关闭
            //    //if (DateTime.Now.Hour <= 19)
            //    //{
            //    //    if (seatState.Contains("0"))
            //    //    {
            //    //        this.SeatNOCmbx.Items.Add(string.Format("{0:G}    状态;{1:G}", titleID, "可选"));
            //    //    }
            //    //    if (seatState.Contains("1"))
            //    //    {
            //    //        this.SeatNOCmbx.Items.Add(string.Format("{0:G}    状态;{1:G}", titleID, "已选"));
            //    //    }
            //    //    if (seatState.Contains("2"))
            //    //    {
            //    //        this.SeatNOCmbx.Items.Add(string.Format("{0:G}    状态;{1:G}", titleID, "系统推荐"));
            //    //    }
            //    //    if (seatState.Contains("3"))
            //    //    {
            //    //        this.SeatNOCmbx.Items.Add(string.Format("{0:G}    状态;{1:G}", titleID, "关闭"));
            //    //    }
            //    //}

            //    #endregion
            //}
            //string filepath = Application.StartupPath+"\\"+"37.txt";
            //Write(filepath, Room_37);
        }

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
             //定时预约

             
            if (timefrm == null || timefrm.IsDisposed)
            {
                timefrm = new TimeSelectfrm();
                timefrm.Cookie = cookie;
                //绑定事件方法
                timefrm.PostParamEvt += Getparams;
                timefrm.Show();
            }
        }

        private void RoomNOCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room_selected = this.RoomNOCmbx.Text;
            string roomNO = GetRoomNO(room_selected);
            SeatInit(roomNO);
        }

        private void SeatNOCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room_name = this.RoomNOCmbx.Text;
            string room_no = GetRoomNO(room_name);
            if (room_no == "35")
            {
                foreach (KeyValuePair<string, string> key in Room_35)
                {
                    if (key.Value == this.SeatNOCmbx.Text)
                    {
                        seatID = key.Key;
                        break;
                    }
                    
                }
            
            }
            if (room_no == "36")
            {
                foreach (KeyValuePair<string, string> key in Room_36)
                {
                    if (key.Value == this.SeatNOCmbx.Text)
                    {
                        seatID = key.Key;
                        break;
                    }
                    
                }
            }
            if (room_no == "31")
            {
                foreach (KeyValuePair<string, string> key in Room_31)
                {
                    if (key.Value == this.SeatNOCmbx.Text)
                    {
                        seatID = key.Key;
                        break;
                    }

                }
            }
            if (room_no == "37")
            {
                foreach (KeyValuePair<string, string> key in Room_37)
                {
                    if (key.Value == this.SeatNOCmbx.Text)
                    {
                        seatID = key.Key;
                        break;
                    }

                }
            }
        }

      
    }
}
