using System;
namespace RecTool
{
    interface ISide
    {
        SideEnum SideEnum { get; }
        System.Data.DataTable Table { get; }
    }
}
