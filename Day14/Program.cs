namespace Day14
{
    class res1
    {
        public string text { get; set; }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient hc = new HttpClient();
            var response = await hc.GetAsync("https://uapis.cn/api/v1/saying");
            Console.WriteLine(response.Content);
            string restr = await response.Content.ReadAsStringAsync();
            Console.WriteLine(restr);


            HttpClient hc2 = new HttpClient();
            byte[] respone = await hc.GetByteArrayAsync("https://cn.bing.com/images/search?view=detailV2&ccid=ZtyrGmDH&id=031B08F856F1C70B3CFBD4D89E570C16D653FC3D&thid=OIP.ZtyrGmDHGuS5970hU7AWpQHaEJ&mediaurl=https://haowallpaper.com/link/common/file/getCroppingImg/16780392500940160&exph=499&expw=890&q=%E5%9B%BE%E7%89%87&ck=28A125D3F3DEECC5ABCDF6A2BC3F1AFF&idpp=rc&form=rc2idp&ajaxhist=0&ajaxserp=0");
            Person<string, bool> p = new Person<string, bool>()
            {
                x = "haha",
                y = true
            };

        }
        static public void showlist<T>(List<T>s)
        {
            foreach (var it in s)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] ar, string[]ar1)
        {
            
        }
    }
    internal class Person<a, b>
    {
        public a x { get; set; }
        public b y { get; set; }
        public string info<C, D>(C c,D d)
        {
            return $"=={this.x}=={this.y}==";
        }
    }
}
