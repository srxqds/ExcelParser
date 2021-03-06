/*----------------------------------------------------------------
// Copyright (C) 2015 广州，Lucky Game
//
// 模块名：
// 创建者：D.S.Qiu
// 修改者列表：
// 创建日期：June 03 2016
// 模块描述：
//----------------------------------------------------------------*/
using System.Linq;

namespace Excel
{
    public partial class FastExcel
    {
        public Worksheet Read(int sheetNumber)
        {
			//excel inde begin from 1
			sheetNumber += 1;
			foreach (Worksheet workSheet in Worksheets) 
			{
				if (workSheet.Index == sheetNumber) 
				{
					workSheet.Read ();
					return workSheet;
				}
			}
			return null;
        }

        public Worksheet Read(string sheetName)
        {
			foreach (Worksheet workSheet in Worksheets) 
			{
				if (workSheet.Name == sheetName) 
				{
					workSheet.Read ();
					return workSheet;
				}
			}
			return null;
        }

    }
}
