// See https://aka.ms/new-console-template for more information
using IBM.Data.Db2;
using System;
using System.IO;



Console.WriteLine("Using DB2 .NET8 provider");

var uid = Environment.GetEnvironmentVariable("uid");

var pwd = Environment.GetEnvironmentVariable("pwd");

var server = Environment.GetEnvironmentVariable("server");

var db = Environment.GetEnvironmentVariable("db");

var security = Environment.GetEnvironmentVariable("security");

//Connection String

string connString = "uid=" + uid + ";pwd=" + pwd + ";server=" + server + ";database=" + db + ";Security=" + security;

DB2Connection con = new DB2Connection(connString);

con.Open();

Console.WriteLine("Connection Opened successfully");

con.Close();

Console.WriteLine("Connection Closed");
