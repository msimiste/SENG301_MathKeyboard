using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathKeyBoard
{
   public partial class Helpers
    {
       
       public bool FormOpen(String name)
       {
           bool create = true;
           foreach (Form OpenForm in Application.OpenForms)
           {
               if (OpenForm.Name == name)
               {
                   create = false;
               }

           }
           return create;
       }

       public Form getOpenForm(object sender, String name)
       {

           foreach (Form OpenForm in Application.OpenForms)
           {
               if (OpenForm.Name == name)
               {
                   return OpenForm;
               }
               
                  

           }
           return ((Form)sender);
       
       }
    }


}
