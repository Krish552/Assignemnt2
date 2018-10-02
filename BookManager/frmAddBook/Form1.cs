using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BookManager; 

namespace frmAddBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strTitle = string.Empty;
            string strAuthor = string.Empty;
            string strIsbn = string.Empty;
            string strVersion = string.Empty;
            int intCopyRightYear = -1; //Why is this -1?  
            clsBooks myBookToAdd = null;
            clsBookManager myBookManager = null; 
            

            try
            {
                strTitle = "Introduction to C#";
                strAuthor = "Dinesh Kumar";
                strIsbn = "69";
                strVersion = "1";
                intCopyRightYear = 2018;
                myBookToAdd = new clsBooks();
                myBookManager = new clsBookManager(); 

                myBookToAdd.Author = strAuthor.Trim();
                myBookToAdd.Title = strTitle.Trim();
                myBookToAdd.CopyRightYear = intCopyRightYear;
                myBookToAdd.ISBN = strIsbn.Trim();
                myBookToAdd.Version = strVersion.Trim();

                myBookManager.AddBook(myBookToAdd); //OMG we added a book!

                //How many books do we have? 
                Debug.Print(myBookManager.MyBooks.Count.ToString());

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message); //OMG What happens here? 
            }
        }
    }
}
