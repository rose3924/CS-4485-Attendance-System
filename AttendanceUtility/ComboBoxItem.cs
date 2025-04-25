/*
 * Used to allow a display string and a value to be added
 * as a combo box list item
 * It will get added to the drop down box as an object
 * which will make the combo box use the display property as the display property.
 * When collecting the selected item we can call the value property to return the database index value
 * 
 * So user sees a readble string an internally we can use the id
 * 
 * Olivia Anderson (ova210001)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceUtility
{
    internal class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}
