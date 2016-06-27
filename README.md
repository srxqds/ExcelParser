# PureExcel
A lightweight excel(2007-) parser!

This is a simple excel reader, it can run on any .Net Framework.

As we know, Excel 2007 is a open xml format and compress with Zip foramt.

It have no third library dependence and almost can run any .net framwork(No Excel Interop, No Open XML SDK
and No using Linq, Xml and DataSet of C# System api),
maybe on window mobile you shoud modify a little for the missing api.

I use the ZipArchive(https://github.com/srxqds/ZipWrapper) and XMLParser(https://github.com/srxqds/XMLParser).


but it should be used on some editor work and no performance requirement situation!

Use Tips:

1.The sheetIndex, rowIndex and columnIndex are range between 0 to count!

2.Maybe some optimization or modify you should make by yourself depending on your needs.


Todo:

1.More flexible api to work!(done)

2.Test and fix the bug and handle some unexpect situation.(done)

3.Add Ceil Comment support!(done)

4.Trim the empty Row and Column!(done)

5.More optimization and test case!

Inspired By:

1.FastExcel:https://github.com/mrjono1/FastExcel/tree/master/FastExcel

2.C# How To Read .xlsx Excel File With 3 Lines of Code:http://www.codeproject.com/Tips/801032/Csharp-How-To-Read-xlsx-Excel-File-With-Lines-of


D.S. Qiu

2016 Guangzhou, Lucky Game
