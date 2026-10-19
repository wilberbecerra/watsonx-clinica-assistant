using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using ClinicaAPI.Models;

namespace ClinicaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly string _connectionString;

        public CitasController(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("cn");
        }

        // ==========================================
        // 1. ENDPOINT PARA AGENDAR CITAS
        // ==========================================
        [HttpPost("crear")]
        public async Task<IActionResult> CrearCita([FromBody] CitaSolicitud solicitud)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var sql = @"
                        INSERT INTO Citas 
                        (Especialidad, NombrePaciente, NumeroDocumento, FechaCita, RangoHorario, HoraPreferida)
                        VALUES 
                        (@Especialidad, @NombreCompleto, @NumeroDocumento, @FechaCitaDeseada, @RangoHorario, @HoraExacta)";

                    var filasAfectadas = await connection.ExecuteAsync(sql, solicitud);

                    if (filasAfectadas > 0)
                        return Ok(new { mensaje = "¡Cita registrada con éxito en la base de datos!" });
                    else
                        return StatusCode(500, "No se pudo registrar la cita.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        // ==========================================
        // 2. ENDPOINT PARA CONTACTAR ASESOR
        // ==========================================
        [HttpPost("registrarContacto")]
        public async Task<IActionResult> RegistrarContacto([FromBody] ContactoSolicitud solicitud)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var sql = @"
                        INSERT INTO ContactosAsesor (NombreCompleto, TelefonoContacto) 
                        VALUES (@NombreCompleto, @TelefonoContacto)";

                    await connection.ExecuteAsync(sql, solicitud);

                    return Ok(new { mensaje = "¡Solicitud recibida! Un asesor te contactará pronto." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno al registrar contacto: {ex.Message}");
            }
        }

        // ==========================================
        // 3. CONSULTAR CITAS
        // ==========================================
        [HttpGet("consultar")]
        public async Task<IActionResult> ConsultarCitas()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    
                    var sql = "SELECT * FROM Citas ORDER BY Id DESC";

                    var listaCitas = await connection.QueryAsync(sql);

                    return Ok(listaCitas);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al consultar citas: {ex.Message}");
            }
        }
    }
}