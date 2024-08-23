using QL_KTX.DBLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KTX
{
     class CheckPhong
    {
        DB db = null;
        public CheckPhong()
        {
            this.db=new DB();
        }
        public DataSet LayDSPhong()
        {
            return db.ExecuteQueryDataSet("select * from PHONG", CommandType.Text);
        }
    }
}
