/*----------------------------------------------------------------
// Copyright (C) 2015 广州，Lucky Game
//
// 模块名：
// 创建者：D.S.Qiu
// 修改者列表：
// 创建日期：June 03 2016
// 模块描述：
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;

namespace PureExcel
{
    /// <summary>
    /// Row that contains the Cells
    /// </summary>
    public class Row
    {

        public const int InValidColumn = 0;
        /// <summary>
        /// The Row Number (Row numbers start at 1)
        /// </summary>
        public int RowIndex { get; set; }
        /// <summary>
        /// The collection of cells for this row
        /// </summary>
        public List<Cell> Cells { get; internal set; }

        internal int m_ColumnStart { get; private set; }
        internal int m_ColumnEnd { get; private set; }

		internal Row(XMLNode rowElement, SharedStrings sharedStrings)
        {
            m_ColumnStart = 1;
            try
            {
				this.RowIndex = int.Parse(rowElement.GetValue("@r"));
            }
            catch (Exception ex)
            {
                throw new Exception("Row Number not found", ex);
            }
			XMLNodeList cellList = rowElement.GetDeepNodeList("c");
		    this.Cells = new List<Cell>();
			if (cellList != null && cellList.Count > 0)
            {
                this.Cells = GetCells(cellList, sharedStrings);
            }
        }

        public Cell GetCell(int columnId)
        {
            foreach (Cell cell in Cells)
            {
                if (cell.ColumnIndex == columnId)
                {
                    return cell;
                }
            }
            return null;
        }

        private
            List<Cell> GetCells(XMLNodeList rowElement, SharedStrings sharedStrings)
        {
            List<Cell> cellList = new List<Cell>();
			foreach (XMLNode cellElement in rowElement)
            {
                Cell cell = new Cell(cellElement, sharedStrings);
                if (!string.IsNullOrEmpty(cell.Value))
                {
                    string valueTrim = cell.Value.Trim();
                    if (!string.IsNullOrEmpty(valueTrim))
                    {
                        cellList.Add(cell);
                        if (cell.ColumnIndex < m_ColumnStart)
                            m_ColumnStart = cell.ColumnIndex;
                        else if (cell.ColumnIndex > m_ColumnEnd)
                            m_ColumnEnd = cell.ColumnIndex;
                    }
                }
            }
		    return cellList;
        }
    }
}
