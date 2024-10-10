using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace DAL
{
    public class DBManager
    {
        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        SqlDataAdapter SqlDataAdapter;
        DataTable DT;

        public DBManager()
        {
            try
            {
                SqlConnection = new SqlConnection();
                SqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["NorthwindCN"].ConnectionString;

                SqlCommand = new SqlCommand();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommand.Connection = SqlConnection;

                SqlDataAdapter = new SqlDataAdapter(SqlCommand);
                DT = new DataTable();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public int ExecuteNonQuery(string SpName)
        {
            int R = -1;
            try
            {
                if (SqlConnection?.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                SqlCommand.CommandText = SpName;     
                SqlCommand.Parameters.Clear();
                R = SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return R;
        }
        public object ExecuteScalar(string SpName)
        {
            object R =new object();
            try
            {
                if (SqlConnection?.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                SqlCommand.CommandText = SpName;
                SqlCommand.Parameters.Clear();
                R = SqlCommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return R;
        }
        public DataTable ExecuteReader(string SpName)
        {
            DT.Clear();
            try
            {
                SqlCommand.CommandText = SpName;
                SqlCommand.Parameters.Clear();

                SqlDataAdapter.Fill(DT);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); //instead of logging
                //exception type ,time , message , stacktrace
            }
            return DT;
        }

        public int ExecuteNonQuery(string SpName ,Dictionary<string,object>ParamList)
        {
            int R = -1;
            try
            {
                if (SqlConnection?.State == ConnectionState.Closed && ParamList?.Count>0)
                {
                    SqlConnection.Open();
                }
                SqlCommand.CommandText = SpName;
                SqlCommand.Parameters.Clear();
                
                foreach (var item in ParamList)
                {
                    SqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                }

                R = SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return R;
        }

        public object ExecuteScalar(string SpName, Dictionary<string, object> ParamList)
        {
            object R = new object();
            try
            {
                if (SqlConnection?.State == ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }
                SqlCommand.CommandText = SpName;
                SqlCommand.Parameters.Clear();
                foreach (var item in ParamList)
                {
                    SqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                }
                R = SqlCommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return R;
        }

        public DataTable ExecuteReader(string SpName, Dictionary<string, object> ParamList)
        {
            DT.Clear();
            try
            {
                SqlCommand.CommandText = SpName;
                SqlCommand.Parameters.Clear();
                foreach (var item in ParamList)
                {
                    SqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                }
                SqlDataAdapter.Fill(DT);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); //instead of logging
                //exception type ,time , message , stacktrace
            }
            return DT;
        }
    }
}
 