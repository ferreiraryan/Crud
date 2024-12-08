using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvcrud
{
    internal class ConexaoAluno
    {
        MySqlConnection comn;


        public void ConectarBD()
        {
            try
            {
                comn = new MySqlConnection("Persist Security info=false; server=localhost; database=bdescola; user=root; pwd=Rv290407;");
                comn.Open();
                //MessageBox.Show("Conectando");
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao conectar" + e.Message);
            }
        }

        public int ExecutarComandos(string sql)
        {
            int resultado;
            try
            {
                //conectar ao banco
                ConectarBD();
                //preparar o comando
                MySqlCommand cmd = new MySqlCommand(sql, comn);
                //executa o comando
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch(Exception)
            {
                resultado = 1;
                throw;
            }
            finally
            {
                comn.Close();
            }
            return resultado;
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, comn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comn.Close();
            }


        }
    }
}
