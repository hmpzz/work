using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class config
    {


        /*
        
            2.  connectionStrings 配置节：
        请注意：如果您的 SQL 版本为 2005 Express 版，则默认安装时 SQL 服务器实例名为localhost/SQLExpress ，须更改以下实例中“ Data Source = localhost; ”一句为“ Data Source = localhost / SQLExpress; ”，在等于号的两边不要加上空格。
        <!-- 数据库连接串 -->
                < connectionStrings >
                    < clear />
                    < add name = "conJxcBook "
                        connectionString = "Data Source=localhost;Initial Catalog=jxcbook;User                                   ID=sa;password=******** "
                        providerName = "System.Data.SqlClient " />
                </ connectionStrings >

        3. appSettings 配置节：
        appSettings 配置节为整个程序的配置，如果是对当前用户的配置，请使用 userSettings 配置节，其格式与以下配置书写要求一样。
        <!-- 进销存管理系统初始化需要的参数 -->
                < appSettings >
                    < clear />
                    < add key = "userName "value = "" />
                    < add key = "password "value = "" />
                    < add key = "Department "value = "" />
                    < add key = "returnValue "value = "" />
                    < add key = "pwdPattern "value = "" />
                    < add key = "userPattern "value = "" />
        </ appSettings >

        */


        #region 4.1 读取connectionStrings配置节
        /// <summary>
        /// 依据连接串名字connectionName返回数据连接字符串
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static string GetConnectionStringsConfig(string connectionName)
        {
            string connectionString =  ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            Console.WriteLine(connectionString);
            return connectionString;
        }

        #endregion

        #region 4.2 更新connectionStrings配置节

        /// <summary>
        /// 更新连接字符串
        /// </summary>
        /// <param name="newName"> 连接字符串名称 </param>
        /// <param name="newConString"> 连接字符串内容 </param>
        /// <param name="newProviderName"> 数据提供程序名称 </param>
        public static void UpdateConnectionStringsConfig(string newName,
            string newConString,
            string newProviderName)
                {
            bool isModified = false;    // 记录该连接串是否已经存在
                                        // 如果要更改的连接串已经存在
            if (ConfigurationManager.ConnectionStrings[newName] != null)
            {
                isModified = true;
            }
            // 新建一个连接字符串实例
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, newConString, newProviderName);
            // 打开可执行的配置文件*.exe.config
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 如果连接串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            // 将新的连接串添加到配置文件中.
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        #endregion


        #region 4.3 读取appStrings配置节
        /// <summary>
        /// 返回＊.exe.config文件中appSettings配置节的value项
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static string GetAppConfig(string strKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == strKey)
                {
                    return ConfigurationManager.AppSettings[strKey];
                }
            }
            return null;
        }
        #endregion

        #region 4.4 更新connectionStrings配置节
        /// <summary>
        /// 在＊.exe.config文件中appSettings配置节增加一对键、值对
        /// </summary>
        /// <param name="newKey"></param>
        /// <param name="newValue"></param>
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion
    }
}
