using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;

namespace DapperTest
{
    class Program
    {
        public const string ConnectionString = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=tlys.oaxmz.5860247";

        public const string OleDbConnectionString = "Provider=SQLOLEDB;Data Source=.;Initial Catalog=tempdb;Integrated Security=SSPI";

        public static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        static void Main(string[] args)
        {
            var connection = GetOpenConnection();

            //1、返回动态对象列表的查询
            Console.WriteLine("1、返回动态对象列表的查询");
            var users = connection.Query("select * from users");
            foreach (var user in users)
            {
                //动态对象的名称与数据库字段的名称一模一样
                Console.WriteLine(user.id+"\t"+user.nickname+"\t"+user.email);
            }
            Console.WriteLine(users.First().nickname);

            //2、返回强类型列表的查询
            Console.WriteLine("2、返回强类型列表的查询");
            var users2 = connection.Query<User>("select * from users");
            foreach (var user in users2)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }

            //3、传递参数的查询
            Console.WriteLine("3、传递参数的查询");
            var users3 = connection.Query<User>("select * from users where email=@email",
                new {email = "liulixiang1988@gmail.com"});
            foreach (var user in users3)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }

            //4、执行不返回结果的命令（更新、删除等）
            Console.WriteLine("4、执行不返回结果的命令（更新、删除等）");
            connection.Execute(@"
              IF EXISTS(SELECT 1 FROM users WHERE nickname=@nickname)
                RETURN;
              insert into users(nickname, email, role) values(@nickname, @email, @role);
            ", new {nickname = "魏安东", email = @"weiad@tlys.cn", role = 0});
            var users4 = connection.Query<User>("select * from users");
            Console.WriteLine("执行不返回结果后的结果集合");
            foreach (var user in users4)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }

            //5、插入或更新集合或者列表(多条记录）
            Console.WriteLine("5、插入或更新集合或者列表(多条记录）");
            var userList = new List<User>
            {
                new User() {NickName = "李向东", Email = "lixd@tlys.cn", Role = 0},
                new User() {NickName = "张彪", Email = "zhangbiao@tlys.cn", Role = 0}
            };
            connection.Execute(@"
              IF EXISTS(SELECT 1 FROM users WHERE nickname=@nickname)
                RETURN;
              insert into users(nickname, email, role) values(@nickname, @email, @role);
            ", userList);
            //执行查询
            var users5 = connection.Query<User>("select * from users");
            Console.WriteLine("执行不返回结果后的结果集合");
            foreach (var user in users5)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }
            //6、dapper支持列表自动分解
            Console.WriteLine("6、dapper支持列表自动分解");
            var users6 = connection.Query<User>(
                @"SELECT * FROM users
                WHERE nickname IN @nicknames", new {nicknames=new string[]{"刘理想", "理想"}})
            ;
            foreach (var user in users6)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }

            //7、执行存储过程
            Console.WriteLine("7、执行存储过程");
            var users7 = connection.Query<User>("sp_get_user", new {nickname = "刘理想"},
                commandType: CommandType.StoredProcedure);
            foreach (var user in users7)
            {
                //注意强类型返回的是User类实例
                Console.WriteLine(user.Id + "\t" + user.NickName + "\t" + user.Email);
            }
            Console.ReadKey();
            if(connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }

    public class User
    {
        public int? Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public int? Role { get; set; }
    }
}
