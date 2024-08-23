using QL_KTX.DBLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KTX
{
    class DSSVinPhong
    {
        DB db = null;

        public DSSVinPhong()
        {
            this.db = new DB();
        }

        public DataSet LayDSSVtrongPhong(string Phong_id2)
        {

            return db.ExecuteQueryDataSet("SELECT * FROM dbo.TIMKIEM('" + Phong_id2 + "')", CommandType.Text);


        }

    }
}
