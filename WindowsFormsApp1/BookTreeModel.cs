using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BookTreeModel
    {
        
        //Ive created a tree structure 
        
        public BookTreeModel()
        {
            Category = String.Empty;
            Children = new List<BookTreeModel>();
        }
        //index
        public int Index { get; set; }
        //category
        public String Category { get; set; }
        //children
        public List<BookTreeModel> Children { get; set; }
    }
}
