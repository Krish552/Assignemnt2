using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using DemoProject;
using BookManager;
using System.Diagnostics;
using Nunit_Example; 
namespace DemoProjectTest
{
    [TestFixture]
    public class DemoTests
    {
        //List<EmployeeDetails> li;
        public List<clsBooks> MyBooks = new List<clsBooks>();
        [Test]
        public void CheckMyBooks()
        {
            //Leave this blank....
            Debug.Print("this is my unit test....nothing wait");
            Program p = new Program();
            MyBooks = p.CheckMyBooks();

            clsBooks y = new clsBooks("JK Rowling", "Kavith's Test", "69", "1.0", 1991); 

            foreach (var x in MyBooks)
            {
                //Assert.IsNotNull(x.Author);
                //Assert.Equals(x.Author, "JK Rowling");
                //Assert.Greater(x.CopyRightYear, 1990);
                //Assert.AreEqual(y, x);
                Assert.IsNotEmpty(x.ISBN, "Whoa!");
                //Assert.IsNotEmpty(x.Author);
                //Assert.IsNotNull(x.ISBN);
                //Assert.IsNotNull(x.Title);
            }
        }

        //public void Checkdetails()
        //{
        //    Program pobj = new Program();
        //    li = pobj.AllUsers();
        //    foreach (var x in li)
        //    {
        //        Assert.IsNotNull(x.id);
        //        Assert.IsNotNull(x.Name);
        //        Assert.IsNotNull(x.salary);
        //        Assert.IsNotNull(x.Geneder);
        //    }
        //}
        //[Test]
        //public void TestLogin()
        //{
        //    Program pobj = new Program();
        //    string x = pobj.Login("Ajit", "1234");
        //    string y = pobj.Login("", "");
        //    string z = pobj.Login("Admin", "Admin");
        //    Assert.AreEqual("Userid or password could not be Empty.", y);
        //    Assert.AreEqual("Incorrect UserId or Password.", x);
        //    Assert.AreEqual("Welcome Admin.", z);
        //}
        //[Test]
        //public void getuserdetails()
        //{
        //    Program pobj = new Program();
        //    var p = pobj.getDetails(100);
        //    foreach (var x in p)
        //    {
        //        Assert.AreEqual(x.id, 100);
        //        Assert.AreEqual(x.Name, "Bharat");
        //    }
        //}
    }
}