---
typora-copy-images-to: assets
---

# day08

## 一、上节回顾

线程: 



###### 任务

```C#
Task t1 =Task.Run(()=>{}); // 开启并启动一个任务
    
Task t2 =new  Task(()=>{}); // 开启一任务
t2.Start(); // 任务启动

Task<数据类型> t1 =Task.Run(()=>{}); // 开启并启动一个任务
```

`Task实例.Result` 慎用 会阻塞线程

`Task实例.await()`  等待线程

```C#
// 批量监视线程 tasks 是线程(任务)数组
Task.WhenAll(tasks).Wait(); // 所有任务全部执行结束才会下一步
Task.WhenAny(tasks).Wait(); // 只要有一个任务执行结束就会下一步
```

```C#	
// Task实例 任务执行结束后才会执行 下一个任务
Task实例.ContinueWith((Task Prev)=>{ // 下一任务
    // Prev 是上一个任务
})
```



## 二、Mysql

数据库：存储数据的仓库。

数据库存储和读写数据的效率、性能比文件方式要高级很多,更安全。

分类：关系型数据库和非关系型数据。

关系型数据：类似于表格方式存储数据的、重量级，代表：SqlServer、Oracle、Mysql、。。。

非关系型数据：类似于List、字典方式存储数据的、轻量级，代表：Redis、Memecache、MongoDb、。。。



小皮安装的MySQL默认的连接配置：

- 主机名或ip地址：`127.0.0.1`或`localhost`
- 账号：`root`
- 密码：`root`



MySQL结构：

> 库==>表==>表头(字段) | 数据(行)



新建库：在左侧菜单栏，鼠标右击，选择新建数据库，在弹窗中输入信息，点击确定

![1787019043419](assets/1787019043419.png) 

操作库，需要双击点绿，就相当于打开这个库了，可以操作这个库了。



新建表：

![1787019144422](assets/1787019144422.png) 

在打开的界面，设计表头(字段)，通常一张表中，一定要有一个唯一的标识（id），主键、自增、无符号

![1787019281961](assets/1787019281961.png) 

添加栏位，设计下一个字段：

![1787019440761](assets/1787019440761.png) 

以此类推，设计表中其他字段就好。

例如性别：

![1787019592371](assets/1787019592371.png)

![1787019609627](assets/1787019609627.png) 

设计好字段后记得保存，会 弹出窗口输入表的名字，点击确定按钮：

![1787019732148](assets/1787019732148.png) 

保存后就可以看见表了：

![1787019765054](assets/1787019765054.png) 

双击打开这张表：

![1787019783026](assets/1787019783026.png) 



操作Mysql的语句：

![1787019885039](assets/1787019885039.png) 

![1787019916306](assets/1787019916306.png) 

- 增

  ```mysql
  # 新增一条数据
  insert into 表名(字段名字,字段名字,...) values(字段对应的值,...);
  ```

  例：

  ```mysql
  insert into user(username,password,age,gender) values("张三","123456",12,"女");
  # 有些字段，会自动生成数据，不用手动添加，例如id
  ```

  

  ![1787020136158](assets/1787020136158.png) 

  ![1787020221143](assets/1787020221143.png) 

  ```mysql
  # 批量增加数据的
  insert into 表名(字段,...) values(值,...),(值,...);
  ```

  例：

  ```mysql
  insert into user(username,password,age,gender,create_at) values("李四","123123",13,"男",'2023-10-15 14:35:00'),("王五","123789",14,"女",'2023-10-15 14:35:00');
  ```

  

- 删

  ```mysql
  delete from 表名 where 条件; # 符合条件的数据删除
  ```

  例：

  ```c#
  delete from user where username="王五";
  ```

  

- 改

  ```mysql
  update 表名 set 字段=新值,字段=值,... where 条件;
  ```

  例：

  ```c#
  update user set username="赵六" where id=4;
  ```

  

- 查

  - 查询所有数据

    ```mysql
    select * from 表名;
    ```

    例：

    ```c#
    select * from user;
    ```

    ![1787021236459](assets/1787021236459.png) 

  - 根据条件查询

    条件：`=`、`>`、`<`、`!=`、`in`、`like`、`between 数字 and 数字` 

    ```mysql
    select * from 表名 where 条件;
    ```

    例：

    ```c#
    select * from user where age!=12;
    
    select * from user where id in (1,4);
    
    select * from user where id between 1 and 4;
    
    select * from user where username like '%三%';
    
    select * from user where age=12 or username="李四";
    
    select * from user where username="张三" and age=14;
    ```

    > 查询的条件也可以用在修改数据和删除数据的语句中。

  - 聚合函数

    ```c#
    # 聚合函数
    select sum(age) as sum from user; # 求表中所有年龄的和，且显示的时候，表头叫sum
    
    select max(id) as maxid from user;
    
    select avg(age) from user;
    
    select count(*) as count from user where age=12 or username="李四";
    ```

  - 排序、分页、分组

    ```mysql
    # 排序
    select * from user order by age; # 升序
    select * from user order by age desc; # 降序
    
    # 分页
    select * from user limit 0,3; # 1
    select * from user limit 3,3; # 2
    select * from user limit 6,3; # 3
    
    # 分组
    select count(*) as count,banji from user group by banji; # 按照banji字段分组，查询数量和banji
    ```

    

重新设计表的结构：

![1787020900731](assets/1787020900731.png) 

这样时间就能自动生成，不用手动添加了。



数据库操作，我们平常项目中的数据都来源于数据库，Mysql是比较常用的数据库。

`C#`中操作Mysql数据库需要依赖第三方库：MySqlConnector。



### 1、连接数据库，并查询数据

- 定义连接字符串

  ```c#
  string ConnStr = "server=127.0.0.1;port=3306;database=novel_db;uid=root;pwd=root;charset=utf8";
  ```

  

- 创建连接对象 `MySqlConnection`，传入连接字符串

  ```c#
  // 使用using可以自动关闭连接，否则还需要手动关闭
  using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr)){}
  ```

  

- 打开连接，可以是同步的，但如果不想阻塞线程，可以使用异步

  ```c#
  MysqlConn.Open();
  await MysqlConn.OpenAsync();
  ```

  

- 创建命令对象 `MySqlCommand`，绑定 SQL 语句与连接

  ```c#
  // 定义查询语句
  string sql = "select * from Table";
  // 定义命令行对象
  using (MySqlCommand Cmd = new MySqlCommand(sql, MysqlConn)){}
  ```

  

- 使用适配器 `MySqlDataAdapter` 填充 DataTable

  ```c#
  MySqlDataAdapter Adapter = new MySqlDataAdapter(Cmd);
  DataTable dt = new DataTable();
  Adapter.Fill(dt);
  ```

  

- 使用数据

  ```c#
  dataGridView1.DataSource = dt;
  ```

> 如果sql语句中有数据，可以在sql语句中占位，然后使用MySqlCommand实例对象，填充数据，例：
>
> ```c#
> // string sql = "select * from users where username=@username";
> Cmd.Parameters.AddWithValue("@username", "user1");
> ```

### 2、增删改操作

```c#
using (MySqlCommand Cmd = new MySqlCommand(sql, MysqlConn))
{
    Cmd.Parameters.AddWithValue("@username", "user3");
    Cmd.Parameters.AddWithValue("@password", "123123");
    Cmd.Parameters.AddWithValue("@nickname", "abc");
    int rows = Cmd.ExecuteNonQuery(); // 受影响的行数
    label1.Text = rows.ToString();
}
```

> 执行方法可以使用异步的：
>
> ```c#
> await MySqlCommand.ExecuteNonQueryAsync();
> ```

- 

### 3、MySqlCommand方法

- 执行增删改sql语句：

  ```c#
  ExecuteNonQuery()
  ExecuteNonQueryAsync()
  ```

  

- 读取第一行第一列数据或聚合结果 使用场景 获取集合查询的结果

  ```c#
  ExecuteScalar()
  ExecuteScalarAsync()
  ```

  例：

  ```c#
  string sql = "select count(*) from users";
  using (MySqlCommand Cmd = new MySqlCommand(sql, MysqlConn))
  {
      object result = Cmd.ExecuteScalar();
      label1.Text = result.ToString();
  }
  ```

  

- 获取Reader

  ```c#
  // ExecuteReader()
  using var reader = await cmd.ExecuteReaderAsync()
  ```

  

### 4、MySqlDataReader方法

- 获取列数

  ```c#
  reader.FieldCount
  ```

  

- 是否至少有一行结果数据

  ```c#
  reader.HasRows;
  ```

  

- 读取数据

  ```c#
  bool hasRow = reader.Read();
  bool hasRow = await reader.ReadAsync();
  ```

  > 返回的布尔值代表是否读到数据

- 获取数据

  ```c#
  // 按字段下标取值，需要指定数据类型
  reader.GetInt32(0); 
  reader.GetString(1);  
  reader.GetDouble(2);
  reader.GetDateTime(3); // 日期
  reader.GetBoolean(4);
  
  // 按字段取值
  reader.GetInt32("id");
  reader.GetString("name");
  ```


### 5、导入导出

导出：在库上右击，选择导出，选择结构和数据，选择文件夹，确定。

导入：新建库，在库上右击，选择运行SQL文件，点击开始，在空白处刷新就看到导入的表了。

