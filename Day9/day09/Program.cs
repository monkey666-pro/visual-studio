using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace day09
{
    internal class Program
    {
        // 定义委托(函数类型)
        delegate void myDelegate(string msg);
        static void Main(string[] args)
        {
            //var o = new other();
            //o.showInfo();
            #region 作业讲解
            //// 装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。
            ////    计算这个半径的圆装修一半需要多少钱？
            //var getPrice = (double r, out double halfPrice) =>
            //{
            //    // 计算面积
            //    double area = Math.PI * r * r;

            //    double totalPrice = area * 200;

            //    halfPrice = totalPrice / 2;

            //    return totalPrice;
            //};

            //Console.WriteLine(getPrice(6,out double price2));
            //Console.WriteLine(price2);


            // 计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //int getCount(string str, char s)
            //{
            //    int count = 0;
            //    foreach (char item in str)
            //    {
            //        if(item == s) count++;
            //    }
            //    return count;
            //}

            //Console.WriteLine(getCount("asdfghasdfqwesss", 'f'));


            //// 计算一个整型数组中，最小值第一次出现的下标。
            //Func<int[], int> getMin = (intArr) =>
            //{
            //    int index = 0; // index存储intArr中最小值的索引
            //    // 循环数组 判断 数组的数据 那个一个比 intArr[index] 更小
            //    ///  找到了就想下标记录在 index中
            //    for (int i = 0; i < intArr.Length; i++)
            //    {
            //        if (intArr[i] < intArr[index]) index = i;
            //    }
            //    return index;
            //};

            //int[] arr = [10, 20, 5, 30, 50,2,1, 6, 7];
            //Console.WriteLine(getMin(arr));

            ////// 判断一个字符串是否为回文，返回布尔值类型。
            //Func<string, bool> isHuiwen = (str) =>
            //{
            //    // 遍历字符串
            //    // str[0]    ====>  str[str.Length-1]
            //    // str[1]    ====>  str[str.Length-1-1]
            //    // str[2]    ====>  str[str.Length-1-2]
            //    // str[3]    ====>  str[str.Length-1-3]
            //    // ....
            //    // str[i]    ====>  str[str.Length-1-i]
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] != str[str.Length - 1 - i]) return false;
            //    }
            //    return true;
            //};
            //Console.WriteLine(isHuiwen("abcdcba"));
            //Console.WriteLine(isHuiwen("abcdcba1"));
            #endregion

            #region 委托
            /**********************************************************************/
            // 先准备函数
            //void sayHi(string userName) { Console.WriteLine($"HI:{userName}"); }            
            //void sayHello(string userName) { Console.WriteLine($"Hello:{userName}"); }
            //void sayBye(string userName) { Console.WriteLine($"byebye:{userName}"); }

            //// 使用
            //myDelegate myDel = sayHi;
            //myDel("Tom");
            //myDel = sayHello;
            //myDel("jack");

            //Action<string> myDel = sayHi;
            //myDel("Tom");
            //myDel = sayHello;
            //myDel("jack");

            //Action<string> myDel = sayHi;
            //myDel += sayHello;
            //myDel += sayBye;

            //myDel = sayHello; // 会覆盖
            //myDel("jack");
            #endregion

            #region 值类型,引用类型
            // 值类型,引用类型
            //int a = 100;
            //int b = a;   // 把a里面的数据100，复制一份给b
            //b = 200;     // 只修改b自己的数据
            //Console.WriteLine(a); // 输出：100


            //int[] arr = [10, 20, 30];
            //int[] newArr = arr; // 将数组存储的地址 复制一份给了变来那个newArr
            //newArr[0] = 666;    // 根据newArr的地址 找到了堆内存 那个数组数据 根据索引修改数据

            //Console.WriteLine(arr[0]); // 666  

            //newArr = [100, 200, 300];  // 在堆内存中开辟一个空间存储[100, 200, 300] 数组数据, 并将地址赋值给newArr变量
            //Console.WriteLine(newArr[0]);// 100

            //int[] arr1 = [1, 2, 3];
            //int[] arr2 = [1, 2, 3];

            //// arr1 和 arr2 中存储的是分别两个 数组空间(堆)的地址
            //Console.WriteLine(arr1 == arr2); // False


            #endregion

            #region 可变数量参数
            // 可变数量参数
            // 可以实现任意个数字的求和
            //var getSum = (params int[] args) =>
            //{
            //    int sum = 0;
            //    foreach (var item in args) sum += item;
            //    return sum;
            //};

            //Console.WriteLine(getSum(1));
            //Console.WriteLine(getSum(1, 2));
            //Console.WriteLine(getSum(1, 2, 3));
            //Console.WriteLine(getSum(1, 2, 3, 4));

            //var fn = (int n1, int n2, params int[] args) =>
            //{
            //    //Console.WriteLine(n1 + n2);
            //    foreach (var item in args) Console.Write(item + " ");
            //    Console.WriteLine();
            //};

            //fn(10, 20);
            //fn(10, 20, 30);
            //fn(10, 20, 30, 40);
            #endregion


            #region ref 和 out
            //// ref 引用传递参数 函数定义及函数调用使用都要使用ref
            //void DoubleIt(ref int x)
            //{
            //    x = x * 2; // 将x变量指向的数据 修改为原来的 2倍
            //}
            //int num = 5;
            //DoubleIt(ref num); // 此时 num和 函数形参x 指向同一个地址 
            //Console.WriteLine(num); // 10

            // 交换两个数字
            //void Swap(ref int a, ref int b)
            //{
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //int n = 10;
            //int m = 100;
            //Swap(ref n, ref m);
            //Console.WriteLine(n);
            //Console.WriteLine(m);


            // 引用类型按值传递
            //void ModifyList(List<int> list) {
            //    Console.WriteLine(list[1]);
            //    list[1] = 999;
            //    Console.WriteLine(list[1]);
            //}

            //List<int> ListInt = [10, 20, 30];
            //ModifyList(ListInt);
            //Console.WriteLine(ListInt[1]);


            // 引用类型参数加上 ref 之后
            //void ModifyList(ref List<int> list)
            //{
            //    Console.WriteLine(list[1]);
            //    list = new List<int> { 100,200,300};
            //    Console.WriteLine(list[1]);
            //}
            //List<int> ListInt = [10, 20, 30];
            //ModifyList(ref ListInt);
            //Console.WriteLine(string.Join("-", ListInt));


            //// 函数内一定要给 out参数赋值
            //void fn(int n, out int x)
            //{
            //    x = 999;
            //}

            ////fn(10, out int y);
            //int y;
            //fn(10, out y);
            //Console.WriteLine(y);

            //void fn(int n, ref int x)
            //{
            //    x = 999;
            //}

            //int y = 10;
            //fn(10, ref y);
            //Console.WriteLine(y);
            #endregion

            #region 箭头函数
            // lambda表达式  也叫箭头函数 ===> 对匿名函数的简写
            // delegate 创建匿名函数, 现在可以使用箭头函数 简写(改写)
            // 箭头函数:   (参数) => {函数体  }
            //var fn = delegate () { };
            //var fn = () => { };

            //var ff = (int n, int m) =>
            //{
            //    return n + m;
            //};
            //Console.WriteLine(ff(10, 20));

            //var f1 = (int n) =>
            //{
            //    return n + 10;
            //};
            // 简写1 省略小括号(只有一个参数)
            //Func<int, int> f1 = n =>
            //{
            //    return n + 10;
            //};
            //Console.WriteLine(f1(10));
            // 简写2 省略大括号和return (前提函数代码只有一样,且这行就是返回值)
            //Func<int, int> f1 = n => n + 10;
            //Console.WriteLine(f1(10));

            //Func<int, int> f1 = n =>
            //{
            //    int m = n + 100;
            //    return m + 10;
            //};
            #endregion

            #region 元组
            //var items = (10, 20.3, "hello", true);
            //Console.WriteLine(items.Item1); // 10
            //Console.WriteLine(items.Item2); // 20.3
            //items.Item1 = 99;
            //Console.WriteLine(items.Item1); // 99

            // (10+10)*20  只有在 .net 10 之后才可以使用 单个的
            // var items = (10,);
            // Console.WriteLine(items.Item1);
            //(int, double, string, bool) item2 = (10, 20.3, "hello", true);

            // 元素命名
            //var items = (name: "zs", id: 10);
            //Console.WriteLine(items.name);

            //(int Id, string Name) product = (205, "Apple");
            //Console.WriteLine(product.Name);

            // 函数返回多个值
            // 返回：年龄、性别、是否成年
            //(int age, string gender, bool isAdult) GetPersonInfo()
            //{
            //    Console.Write("请输入年龄：");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.Write("请输入性别：");
            //    string gender = Console.ReadLine();
            //    bool isAdult = age >= 18;
            //    // 将数据 组装为 元组并返回
            //    return (age, gender, isAdult);
            //}
            ////(int age, string gender, bool isAdult) items =  GetPersonInfo();
            ////Console.WriteLine(items.age);
            //var (age1,gender1,isCn) = GetPersonInfo();
            //Console.WriteLine(age1);

            //var items = (10, "abc", true);
            //var (n, _, isMan) = items;
            //Console.WriteLine(isMan);

            //var (n,s,isO) =(10, "abc", true);
            //Console.WriteLine(s);

            //var fn = ((string, int) info) =>
            //{
            //    Console.WriteLine(info.Item1);
            //    Console.WriteLine(info.Item2);
            //};

            //fn(("zs", 18));

            //List<(string, int)> list = [
            // ("zs",100),
            // ("ls",90),
            // ("ww",80)
            //];

            //list.Add(("zl", 99));

            //foreach (var (name, score) in list)
            //{
            //    Console.WriteLine($"{name}--{score}");
            //}


            // Func 函数参数不可以使用out
            //Func<int,int, int> fn = delegate (int n,out int m)  // 报错
            //{
            //    m = 99;
            //    return n * 2;
            //};
            #endregion

            #region 回调函数
            // 回调函数：函数是可以传递参数的，参数可以是任意数据类型，函数也有类型，可以把函数理解成变量，函数也可以作为另一个函数的参数。作为参数使用的这个函数 ==> 回调函数。
            //Action fn = () =>
            //{
            //    Console.WriteLine("我是fn,我要及时干饭");
            //};

            //var ff = (Action f)=>{
            //    Console.WriteLine("我是ff,我喜欢做饭");
            //    f(); // 此处的f是 ff函数调用时候传进来的 外部的fn函数
            //         // 执行f()  ====> 在函数内执行了 fn() 函数的调用
            //};

            //ff(fn);
            #endregion


            #region List高级方法
            // List高级方法
            //ForEach：遍历
            //list.ForEach(函数)
            // list.ForEach((item) =>
            // {
            //     遍历 逐次执行传入的这个函数, 并且会将list中的数据依次作为这个函数的参数传递
            // })
            //List<int> list1 = [100, 200, 300, 400, 500, 300];
            //Action<int> fn = n => Console.WriteLine(n);
            //list1.ForEach(fn);

            //list1.ForEach(n => Console.WriteLine(n));


            // Find: 找第一个满足条件的元素
            // Find方法返回值: 找第一个满足条件的元素
            // 要求传入的函数比如有 返回 布尔值(条件判断) 
            //   - 如果找到了满足条件的元素则 传入的函数不在继续执行
            //List<int> list2 = [100, 200, 300, 400, 500, 300];
            //int res = list2.Find(item =>
            //{
            //    //Console.WriteLine("find");
            //    //return 条件;
            //    //return item == 200;
            //    //return item > 200;
            //    return item > 2000;
            //});
            //Console.WriteLine(res);


            //FindLast：找最后一个满足条件的元素
            // 传入的函数会 按照list元素从后往前依次执行
            //List<int> list3 = [100, 200, 300, 400, 500, 600];
            //int res = list3.FindLast(item =>
            //{
            //    //Console.WriteLine(item);                
            //    //return item == 200;
            //    return item > 200;
            //    //return item > 2000;
            //});



            //FindAll：找所有满足条件的元素  
            // 返回值是找到满足条件的所有元素组成的list 类型和原list一样
            List<int> list4 = [100, 200, 300, 400, 300, 400, 600];
            var res = list4.FindAll(item =>
            {
                return item > 200;
            });
            //Console.WriteLine(JsonSerializer.Serialize(res));


            // IndexOf：元素第一次出现的下标

            // FindIndex: 找第一个满足条件的元素下标
            List<int> list5 = [100, 200, 300, 400, 300, 400, 600];

            var resIndex = list5.FindIndex(item =>
            {
                //return item > 300;
                return item > 3000;

            });
            //Console.WriteLine(resIndex);

            // FindLastIndex：找最后一个满足条件的下标
            List<int> list6 = [100, 200, 300, 400, 300, 400, 600];
            var resIndex2 = list5.FindLastIndex(item =>
            {
                return item < 400;
            });
            //Console.WriteLine(resIndex2);

            // Exists：判断是否有满足条件的元素
            List<int> list7 = [100, 200, 300, 400, 300, 400, 600];
            bool resBool = list7.Exists(item =>
            {
                //Console.WriteLine(item);
                return item > 200;
                //return item < 200;
                //return item > 500;
                //return item > 700;
            });
            //Console.WriteLine(resBool);


            // TrueForAll：判断是否所有元素都满足条件
            //List<int> list8 = [100, 200, 300, 400, 300, 400, 600];
            //bool resBool2 = list8.TrueForAll(item =>
            //{
            //    Console.WriteLine(item);
            //    return item < 300;
            //    //return item < 5000;
            //});
            //Console.WriteLine(resBool2);


            //ConvertAll：将List中每个元素都返回新元素组成新List
            // 新的list = 原本list.ConvertAll(item => 返回新list的元素);
            // ConvertAll: 会根据list中的数据 依次执行传入的函数,并将每次函数执行的返回值 作为新list的元素
            List<int> list9 = [100, 200, 300, 400];
            //List<int> newList = list9.ConvertAll(item =>
            //{
            //    //Console.WriteLine(item);
            //    return item/2;
            //});

            List<int> newList = list9.ConvertAll(item => item / 2);
            //Console.WriteLine(string.Join(",",newList));

            // RemoveAll：删除所有满足条件的元素, 返回删掉的个数
            List<int> list10 = [100, 200, 300, 400];
            //var resCount = list10.RemoveAll(item => item > 200);
            var resCount = list10.RemoveAll(item => item > 300);
            //Console.WriteLine(resCount);
            //Console.WriteLine(string.Join(",", list10));

            // Sort：排序
            // list.Sort((参数1,参数2)=>参数1-参数2)  升序排序
            // list.Sort((参数1,参数2)=>参数2-参数1)  降序排序
            // 传入的函数会多次执行, 参数1 和参数2 拿到list中的前后来两个数据

            List<int> list11 = [9, 2, 7, 5, 8, 3, 1, 4, 6];
            //list11.Sort((int n, int m) => { return n - m; });
            //Console.WriteLine(string.Join(",", list11));
            //list11.Sort((int n, int m) => { return m - n; });
            //Console.WriteLine(string.Join(",", list11));
            //list11.Sort((int n, int m) => {
            //    //Console.WriteLine($"{n} - {m}")              
            //    return n - m;
            //});
            #endregion

        }
    }
}
