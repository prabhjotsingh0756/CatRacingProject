using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatRacingProject
{
    public class Operation
    {

        //here we need to set the rdio button enble disble 
        public void dsble(CheckBox chk) {
            chk.Checked = false;
        }

        //here we need to pss the vlue 
        public void genNo(ComboBox cb)
        {
            for (int y=5;y<=50;y=y+5) {
                cb.Items.Add(y);
            }
        }
        Random rd = new Random();
        public int move()
        {
            return rd.Next(1, 30);
        }
        public int stop()
        {
            return 950;
        }
    }
}
