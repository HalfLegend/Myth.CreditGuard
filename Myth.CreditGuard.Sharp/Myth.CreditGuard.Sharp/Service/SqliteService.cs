using Myth.CreditGuard.Sharp.Model.Entity;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Myth.CreditGuard.Sharp.Service
{
    public static class SqliteService
    {
        public static SQLiteConnection SqliteConnection { get; }
        static SqliteService()
        {
            ISQLitePlatform sqlitePlatform = null;
            sqlitePlatform = new SQLitePlatformIOS();
            SQLiteConnectionString sqliteConnectionString = new SQLiteConnectionString(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SQLite"), false);
            SqliteConnection = new SQLiteConnectionWithLock(sqlitePlatform, sqliteConnectionString);

            SqliteConnection.CreateTable<BankEntity>();
        }

    }
}
