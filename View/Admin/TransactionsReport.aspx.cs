using LABPSD_RAAMEN.Dataset;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Report;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABPSD_RAAMEN.View.Admin
{
    public partial class TransactionsReport : System.Web.UI.Page
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = GetData(AdminHandler.GetDataHeader());
            report.SetDataSource(data);
        }

        private DataSet1 GetData(List<header> headers)
        {
            var dataSet = new DataSet1();
            var headertable = dataSet.header;
            var detailtable = dataSet.detail;
            var incometable = dataSet.income;

            decimal totalIncome = 0;           

            foreach (header h in headers)
                    {
                        decimal subtotal = 0;

                        var hrow = headertable.NewRow();
                        hrow["Id"] = h.Id;
                        hrow["customerID"] = h.customerID;
                        hrow["staffID"] = h.staffID;
                        hrow["date"] = h.date;

                        headertable.Rows.Add(hrow);

                        foreach (detail d in h.details)
                        {
                            var drow = detailtable.NewRow();
                            drow["headerID"] = d.headerID;
                            drow["ramenID"] = d.ramenID;
                            drow["quantity"] = d.quantity;
                            drow["subtotal"] = d.quantity * int.Parse(d.raman.price);

                            detailtable.Rows.Add(drow);

                            // Menghitung subtotal setiap transaksi
                            decimal price = AdminRepository.GetRamenPrice(d.ramenID);// Ambil harga dari ramen berdasarkan d.ramenID
                            subtotal += d.quantity * int.Parse(d.raman.price);
                        }

                // Menyimpan nilai subtotal pada kolom "Subtotal"
                        hrow["Total"] = subtotal;

                        // Menambahkan subtotal ke total pendapatan
                        totalIncome += subtotal;
                    }

            var irow = incometable.NewRow();
            irow["grandIncome"] = totalIncome;
            incometable.Rows.Add(irow);

            return dataSet;
        }

    }
}