using LMS.Entities;
using MySql.Data.MySqlClient;

namespace LMS.Repository
{
    public class TheLoaiRepository
    {
        private readonly string _connectionString = @"server=localhost;port=3306;user=root;password=;database=library";

        public List<TheLoai> GetAll()
        {
            var list = new List<TheLoai>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT IdTheLoai, TenTheloai FROM TheLoai";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TheLoai
                            {
                                IdTheLoai = reader.GetInt32("IdTheLoai"),
                                TenTheloai = reader.IsDBNull(reader.GetOrdinal("TenTheloai")) 
                                    ? null 
                                    : reader.GetString("TenTheloai")
                            });
                        }
                    }
                }
            }
            return list;
        }

        public TheLoai? GetById(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT IdTheLoai, TenTheloai FROM TheLoai WHERE IdTheLoai = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TheLoai
                            {
                                IdTheLoai = reader.GetInt32("IdTheLoai"),
                                TenTheloai = reader.IsDBNull(reader.GetOrdinal("TenTheloai")) 
                                    ? null 
                                    : reader.GetString("TenTheloai")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public TheLoai? GetByName(string name)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT IdTheLoai, TenTheloai FROM TheLoai WHERE TenTheloai = @name";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TheLoai
                            {
                                IdTheLoai = reader.GetInt32("IdTheLoai"),
                                TenTheloai = reader.IsDBNull(reader.GetOrdinal("TenTheloai")) 
                                    ? null 
                                    : reader.GetString("TenTheloai")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public TheLoai Add(TheLoai theLoai)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO TheLoai (TenTheloai) VALUES (@tenTheloai); SELECT LAST_INSERT_ID();";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenTheloai", theLoai.TenTheloai ?? (object)DBNull.Value);
                    var newId = Convert.ToInt32(command.ExecuteScalar());
                    theLoai.IdTheLoai = newId;
                }
            }
            return theLoai;
        }

        public TheLoai Update(TheLoai theLoai)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "UPDATE TheLoai SET TenTheloai = @tenTheloai WHERE IdTheLoai = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenTheloai", theLoai.TenTheloai ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@id", theLoai.IdTheLoai);
                    command.ExecuteNonQuery();
                }
            }
            return theLoai;
        }

        public TheLoai? DeleteById(int id)
        {
            var theLoai = GetById(id);
            if (theLoai == null) return null;

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "DELETE FROM TheLoai WHERE IdTheLoai = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            return theLoai;
        }

        public List<TheLoai> Search(string keyword)
        {
            var list = new List<TheLoai>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT IdTheLoai, TenTheloai FROM TheLoai WHERE LOWER(TenTheloai) LIKE @keyword";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", $"%{keyword.ToLower()}%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TheLoai
                            {
                                IdTheLoai = reader.GetInt32("IdTheLoai"),
                                TenTheloai = reader.IsDBNull(reader.GetOrdinal("TenTheloai")) 
                                    ? null 
                                    : reader.GetString("TenTheloai")
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}