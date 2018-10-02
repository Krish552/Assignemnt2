using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace BookManager
{
    public class clsBooks
    {
        private string _strAuthor;
        private string _strTitle;
        private string _strISBN; //I don't know what this means 
        private string _strVersion;
        private int _intCopyRightYear; 

        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Version { get; set; }
        public int CopyRightYear { get; set; }



        //We will leave complex data types out for right now
        public clsBooks()
        {
            //Leave this blank for right now 
        }

        public clsBooks(string strAuthor, string strTitle, string strISBN, 
            string strVersion, int intCRYear)
        {
            this._strAuthor = strAuthor;
            this._strTitle = strTitle;
            this._strISBN = strISBN;
            this._strVersion = strVersion;
            this._intCopyRightYear =  Convert.ToInt32(intCRYear);  //Just in case some1 passes a string
        }
        

        public void AddBook()
        {

        }


    }

    public class clsBookManager
    {
        public List<clsBooks> MyBooks = new List<clsBooks>();      

        public bool AddBook(clsBooks aBookToAdd)
        {
            clsBooks bookFound = null;
            bool blnAddedSuccessfully = false; 

            try
            {
                //Lets see how to query 
                bookFound = MyBooks.Find(x => x.ISBN == aBookToAdd.ISBN); 

                if(bookFound == null)
                {
                    //Then add to the list 
                    MyBooks.Add(aBookToAdd);
                    blnAddedSuccessfully = true; 
                }
                else
                {
                    //Guise this...and & don't add to the list 
                    blnAddedSuccessfully = false; 
                }

            }
            catch (Exception ex)
            {
                Debug.Print("There's been an error: " + ex.Message.ToString());
                blnAddedSuccessfully = false; 
            }

            return blnAddedSuccessfully; 
        }

    }

}
