﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_MEDIA.Libs
{
    public class ToolsLeandre
    {

        public string dateFormatBDD(DateTimePicker pickerDate)
        {
            DateTime myTime = pickerDate.Value;
            string myDay = Convert.ToString(myTime.Day);
            string myMonth = Convert.ToString(myTime.Month);
            string myYear = Convert.ToString(myTime.Year);

            string dateFinal = myYear + '-' + myMonth + "-" + myDay;

            return dateFinal;
        }

        public async Task rgbb(Form thisF)
        {
            while (true)
            {
                await Task.Delay(20);
                thisF.BackColor = Color.Blue;
                await Task.Delay(20);
                thisF.BackColor = Color.Red;
                await Task.Delay(20);
                thisF.BackColor = Color.LightGreen;
                await Task.Delay(20);
                thisF.BackColor = Color.Yellow;
            }
        }
    }
}
