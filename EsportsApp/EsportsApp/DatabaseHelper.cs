using System;
using System.Data;
using Npgsql;

namespace EsportsApp
{
    public static class DatabaseHelper
    {
        // PostgreSQL bağlantı dizesi
        public static readonly string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor"; // ConnectionString'i public yapın

        // Bağlantı dizesine dışarıdan erişim için public property
        public static string ConnectionStringPublic => ConnectionString; // Alternatif olarak public bir property ekleyebilirsiniz

        // SQL sorgularını çalıştırıp sonuçları DataTable olarak döndüren metot
        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                using (var conn = new NpgsqlConnection(ConnectionStringPublic))
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        var dataTable = new DataTable();
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri tabanı hatası: {ex.Message}");
            }
        }

        // Parametreli SQL sorgularını çalıştırıp sonuçları DataTable olarak döndüren metot
        public static DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var conn = new NpgsqlConnection(ConnectionStringPublic))
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        var dataTable = new DataTable();
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri tabanı hatası: {ex.Message}");
            }
        }

        // SQL sorgularını çalıştırıp etkilenen satır sayısını döndüren metot
        public static int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var conn = new NpgsqlConnection(ConnectionStringPublic))
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri tabanı hatası: {ex.Message}");
            }
        }

        // Tek bir değeri döndüren SQL sorgularını çalıştıran metot
        public static object ExecuteScalar(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var conn = new NpgsqlConnection(ConnectionStringPublic))
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri tabanı hatası: {ex.Message}");
            }
        }
    }
}