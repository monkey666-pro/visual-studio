# day06

## 上节回顾

 数组定义方式: 可以固定长度定义, 也可以初始值定义, 简写

```C#
// 数组特点,通过下标访问, 长度不可变(不可以删除新增元素), 元素可以修改
类型[] 变量 = new 类型[长度];
类型[] 变量 = new (){...};
类型[] 变量 = {...};
类型[] 变量 = [...];
// List 加强版数组(通过下标操作), 可以通过下标修改,新增, 可以通过方法删除,新增及其他的查询等操作 
List<类型> 变量 = [...]
```

List去重: 找到List中重复的元素删除,  通过字典的键是唯一, 将List中的元素添加到新List中(重复不添加)

字典方法:

- Add 新增
- Remove 删除
- Clear  清除
- Count 元素个数
- ContainsKey   判断键是否存在
- ContainsValue 判断值是否存在
- Keys  获取键的集合
- Values 获取值的集合
- TryAdd  添加(如果键名存在不会报错)

冒泡排序:  前后两两数据比较大小, 交换位置

```c#
for(var i = 0;i<list.Count-1;i++){
    for(var j =0;j<list.Count-1-i;j++){
        if(list[j] > list[j+1]){
            var tmp = list[j];
            list[j] = list[j+1];
            list[j+1] = tmp;            
        }        
    }    
}
```



## 一、字符串方法

字符串是只读数据，可以用下标获取字符，但不能修改。

```c#
 // 字符串: 一串字符的集合, 字符串的内容不可变,但是可以通过下标访问内容
 string str = "abcdefg";
 //Console.WriteLine(str[0]);
 //Console.WriteLine(str[1]);
 //str[0] = "s"; // 报错, 字符串内容不可修改

```

### null

null是一个关键字，表示变量空间不跟任何数据空间产生关联的关系。

正常（值不为null）的变量，一般都是在栈内存中开辟变量空间，跟数据空间产生关联来存储的。

当一个变量赋值为null的时候，就表示这个变量空间不跟任何数据空间产生关联。原本使用的数据就会被销毁掉了。

如果希望给一个变量赋值为null，可以在类型和变量名之间加`?`

```c#
// int底层语法不允许为null
int? a = null; // 表示整型变量a允许为null
// 字符串允许为null
string b = null; // 字符串的null 等同于 ""
b = b += "abc";
```

### 字符串方法属性

- Length获取字符串长度

  ```C#
  // 字符串可以通过Length属性 获取字符串的长度
  //Console.WriteLine(str.Length); // 7
  // 可以使用 下标 配合 长度 完成字符串的遍历
  for (int i = 0; i < str.Length; i++) Console.WriteLine(str[i]);
  ```

  - 利用遍历对字符串去重

    ```C#
    // 字符串去重
    string str = "abcedgjjjsssabcd";
    string resStr = ""; // 去重后的字符串
    //遍历str
    for (int i = 0; i < str.Length; i++)
    {
        // 循环判断 str[i] 在resStr中是否存在
        int j = 0;
        for (; j < resStr.Length; j++)
        {
            // 如果str[i] 在resStr中存在则终止for-j循环
            if (str[i] == resStr[j]) break;
        }
        /*
            for-j循环结束
            1. for循环条件为false, 循环结束, 那么循环结束后j == resStr.Length
            2. for循环中执行了break(str[i]在resStr中存在),循环结束, 循环条件还是true             
        */
        // 循环结束后 j == resStr.Length 成立, 说明for-j循环中没有执行break, 那么str[i] 在resStr中不存在
        if (j == resStr.Length) resStr += str[i];
    }
    Console.WriteLine(resStr);
    ```

- string.IsNullOrEmpty：判断字符串是否为空或null

- string.IsNullOrWhiteSpace：判断字符串是否为null或空格

  ```C#
  // 字符串 空值 判断
  //string.IsNullOrEmpty：判断字符串是否为空或null
  //string.IsNullOrWhiteSpace：判断字符串是否为null或空格
  
  //string str = null;
  ////bool res = string.IsNullOrEmpty(str);
  //bool res = string.IsNullOrWhiteSpace(str);
  //Console.WriteLine(res); // True
  
  //string str = "";
  ////bool res = string.IsNullOrEmpty(str);
  //bool res = string.IsNullOrWhiteSpace(str);
  //Console.WriteLine(res); // True
  
  //string str = "   ";
  ////bool res = string.IsNullOrEmpty(str); // False
  //bool res = string.IsNullOrWhiteSpace(str); // True
  //Console.WriteLine(res); 
  
  //string str = "abc";
  ////bool res = string.IsNullOrEmpty(str); // False
  //bool res = string.IsNullOrWhiteSpace(str); // False
  //Console.WriteLine(res);
  ```

- Substring：截取字符串

  ```C#
   // Substring：截取字符串
   // 字符串.Substring(开始下标)   // 从开始下标到最后截取字符串内容
   // 字符串.Substring(开始下标,个数) // 从开始下标根据个数,截取字符串内容
   string str = "abcdefg";
   //string res = str.Substring(2);
   string res = str.Substring(2, 3);
   Console.WriteLine(res);
  ```

- Contains：判断字符串中是否包含小字符串（子串）

  ```C#
  string str = "abcdefg";
  //bool res = str.Contains("bc");
  bool res = str.Contains("bcaa");
  Console.WriteLine(res);
  ```

  例：去重

  ```C#
  // 使用Contains 字符串去重
  string str = "abcedgjjjsssabcd";
  string resStr = ""; // 去重后的字符串
  //遍历str
  for (int i = 0; i < str.Length; i++)
  {
      if (!resStr.Contains(str[i])) resStr += str[i];
  }
  Console.WriteLine(resStr);
  ```

- StartsWith：判断字符串是否用某个子串开头

- EndsWith：判断字符串是否以某个子串结尾

  ```C#
  string str = "abcdddddefg";
  //bool res = str.StartsWith("a");
  //bool res = str.StartsWith("abc");
  //bool res = str.StartsWith("aaa");
  //bool res = str.EndsWith("g");
  //bool res = str.EndsWith("efg");
  bool res = str.EndsWith("aaa");
  Console.WriteLine(res);
  ```

- IndexOf：在字符串中找某个子串第一次出现的下标，找到得到下标，找不到得到-1

  ```C#
  // 字符串.IndexOf(子串)  查找子串第一次出现的下标
  // 字符串.IndexOf(子串,开始下标)  从开始下标查找子串第一次出现的下标            
  string str = "abcdebfg";
  //int index = str.IndexOf("b");
  int index = str.IndexOf("k");
  //int index = str.IndexOf("b",2);
  Console.WriteLine(index);
  ```

  

- LastIndexOf：在字符串中找某个子串最后一次出现的下标，找到得到下标，找不到得到-1

  ```C#
  // 语法参数和IndexOf 一样
  //string str = "abcdebfg";
  ////int index = str.LastIndexOf("b");
  ////int index = str.LastIndexOf("b", 2);
  //int index = str.LastIndexOf("b",0 );
  //Console.WriteLine(index);
  ```

  

- ToUpper：将字符串中的小写字母转成大写字母

  - 只有字母区分大小写，其他字符没有大小写区分

- ToLower：将字符串中的大写字母转成小写字母

  ```C#
  // ToUpper: 将字符串内容转为大写
  // ToLower: 将字符串内容转为小写
  // 注意: 只有英文字符串才有大小写区分
  string str = "abcDDDDefg";
  Console.WriteLine(str.ToUpper()); // ABCDDDDEFG
  Console.WriteLine(str.ToLower()); // abcddddefg
  ```

  

- Trim：去除字符串首尾两端的空格

  补充：类型中还有一种类型char类型，字符类型，单个字符(字符串)

  ```C#
  // string 字符串类型 使用双引号包裹 表示一串字符的集合 一般用表示一段内容 
  // char 字符类型 使用单引号包裹, 表示单个字符, 字符类型可以和整型转换
  //string str = "ABC";
  //char s = 'A';
  //Console.WriteLine((int)s);
  ```

- TrimStart：去除开头的空格

- TrimEnd：去除结尾的空格

  ```C#
  // Trim：去除字符串首尾两端的空格
  //string str = "  abc    ";
  //Console.WriteLine("-" + str + "|"); // -  abc    |
  //string res = str.Trim();
  //Console.WriteLine("-" + res + "|"); // -abc|
  
  // TrimStart：去除开头的空格
  //string str = "  abc    ";
  //Console.WriteLine("-" + str + "|"); // -  abc    |
  //string res = str.TrimStart();
  //Console.WriteLine("-" + res + "|"); // -abc    |
  
  // TrimEnd：去除结尾的空格
  string str = "  abc    ";
  Console.WriteLine("-" + str + "|"); // -  abc    |
  string res = str.TrimEnd();
  Console.WriteLine("-" + res + "|"); // -  abc|
  ```

  

- Replace：将字符串中指定的子串都替换成的新的子串

  ```C#
  // Replace：将字符串中指定的子串都替换成的新的子串
  //string str = "abacdaeafeeg";
  ////Console.WriteLine(str.Replace("a","0"));
  //Console.WriteLine(str.Replace("ee","**"));
  
  // 敏感词替换为 * , 而且个数要保持一致
  string str = "生活总会有大麻烦, 黑夜总会过去";
  // 假设list存储敏感词
  List<string> mgc = ["大麻", "夜总会"];
  
  
  
  // 生活总会有**烦, 黑***过去
  ```

  

- 分割字符串 Split

  例：`"you love i"`转成`"I Love You"`

- string.Concat：将多个字符串拼接成一个大字符串

- string.Join：将数组或List中的所有元素使用指定的连接符拼接成一个字符串

- PadLeft：给字符串左边填充指定的符号填满指定的长度

- PadRight：给字符串右边填充指定的符号填满指定的长度

- Remove：删除字符串中的一段


## 二、正则表达式

### 1、概念

用于处理字符串的规则。可以验证字符串是否符合某种规则，例如验证用户输入的用户名是否符合规范；可以提取字符串中符合规则的部分，例如将一段话中的关键信息（手机号）提取出来；可以将字符串中符合规则的部分替换成新的内容，例如将文章中的敏感词替换成星号。

这个规则是使用一些特殊符号组成的。主要分为字符和量词组成，另外有一些特殊意义的符号，例如位置锚点、分组、选择等符号。

定义语法：

```c#
@"字符"；
```

### 2、普通字符

用来匹配字符串中对应的字符。

例：

```c#
@"a";
```

### 3、处理字符串的方法

#### 3.1、提取

```c#
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reg = @"a";
            string str = "bac";
            Match res = Regex.Match(str, reg);
            Console.WriteLine(res.Value); // a
        }
    }
}
```

#### 3.2、验证方法

```c#
string reg = @"a";
bool res = Regex.IsMatch("bac", reg);
Console.WriteLine(res); // True
bool res1 = Regex.IsMatch("bcd", reg);
Console.WriteLine(res1); // False
```

#### 3.3、替换方法

```c#
string reg = @"a";
string res = Regex.Replace("bac", reg, "e");
Console.WriteLine(res); // bec
```

### 4、特殊字符

代表规则中要匹配的字符。

| 符号      | 含义                             |
| --------- | -------------------------------- |
| `.`       | 任意一个字符                     |
| `\d`      | 任意一个数字                     |
| `\w`      | 任意一个字母、数字、下划线       |
| `\s`      | 一个空格                         |
| `\D`      | 任意一个非数字字符               |
| `\W`      | 任意一个非字母、数字、下划线字符 |
| `\S`      | 任意一个非空格字符               |
| `[字符]`  | 中括号中的任意一个字符           |
| `[^字符]` | 非中括号中的任意一个字符         |

### 5、量词

修饰前面的字符要匹配到的数量。

| 符号    | 含义             |
| ------- | ---------------- |
| `*`     | 任意个           |
| `+`     | 至少1个          |
| `?`     | 至多1个          |
| `{m}`   | 必须是m个        |
| `{m,}`  | 至少m个          |
| `{m,n}` | 至少m个，至多n个 |

### 6、其他符号

| 符号              | 含义                                   |
| ----------------- | -------------------------------------- |
| `^`               | 放在正则开头，修饰必须以哪个字符开头   |
| `$`               | 放在正则结尾，修饰必须以哪个字符结尾   |
| `|`               | 或者                                   |
| `[\u4e00-\u9fa5]` | 1个汉字                                |
| `\`               | 转义符，将特殊含义的字符的特殊含义去掉 |



### 7、多次提取

```c#
string reg = @"a|b";
MatchCollection res = Regex.Matches("abc", reg);
Console.WriteLine(res[0]);
Console.WriteLine(res[1]);
```

### 8、分组

用小括号表示一组

```c#
string reg = @"(\d{4})-(\d{2})-(\d{2})";
Match res = Regex.Match("2026-07-22", reg);
Console.WriteLine(res.Value); // 2026-07-22
Console.WriteLine(res.Groups[0]); // 2026-07-22
Console.WriteLine(res.Groups[1]); // 2026
Console.WriteLine(res.Groups[2]); // 07
Console.WriteLine(res.Groups[3]); // 22
Console.WriteLine(res.Groups.Count); // 4
```

`?:`放在小括号中，表示不产生分组，只用于匹配使用。

例：

```c#
string reg = @"(?:\d{4})-(?:\d{2})-(?:\d{2})";
Match res = Regex.Match("2026-07-22", reg);
Console.WriteLine(res.Value); // 2026-07-22
Console.WriteLine(res.Groups[0]); // 2026-07-22
Console.WriteLine(res.Groups[1]); // 
Console.WriteLine(res.Groups.Count); // 1
```



案例：

- 手机号

- qq号

- 邮箱号

- 提取一句话中的所有工资

- 提取一句话中所有的中文姓名
- 替换所有多余空格
- 身份证号码
- 密码强度检测：强中弱（字母、数字、特殊符号）

