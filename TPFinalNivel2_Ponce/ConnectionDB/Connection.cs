﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConnectionDB
{
    public class Connection
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string _database;
        public Connection()
        {
            this._database = ConfigurationManager.AppSettings["db_catalogo"];
            this._connection = new SqlConnection(_database);
            this._command = new SqlCommand();
        }
        public SqlDataReader Reader
        {
            get { return this._reader; }
        }

        //Procedimiento para setear la consulta
        public void SetQuery(string query)
        {
            this._command.CommandType = System.Data.CommandType.Text;
            this._command.CommandText = query; 
        }
        //Procedimiento para setear los parametros
        public void SetParam(string param, object value)
        {
            this._command.Parameters.AddWithValue(param, value);
        }
        //Metodo para ejecutar la consulta, retorna la cantidad de filas afectadas
        //en la consulta
        public int QueryExecute()
        {
            this._command.Connection = _connection;
            try
            {
                this._connection.Open();
                return this._command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Procedimiento para ejecutar la lectura de la base de datos
        //la informacion es almacenada en la propiedad _reader
        public void ReaderExecute()
        {
            this._command.Connection = this._connection;
            try
            {
                this._connection.Open();
                this._reader = this._command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Procedimiento para cerrar la conexion
        public void CloseConnection()
        {
            if (this._reader != null)
                this._reader.Close();

            this._connection.Close();
        }

        //Funcion para mostrar el valor de la conexion a la base de datos
        public string Database
        {
            get { return this._database; }
        }
    }
}
