using Microsoft.AspNetCore.Mvc;
using Trafico.BusinessObjects.AutoBal;
using Trafico.Facade.AutoBal;
using Newtonsoft.Json;
using LibreriaBSNetCore.Exceptions;
using System.Net.NetworkInformation;
using System;
using System.IO;
using Trafico.WebApi.Utils;

namespace SisAutoBal.SDKWebApi.Controllers
{
    [Route("iclock")]
    [ApiController]
    public class IclockController : ControllerBase
    {
        public IclockController()
        {
           
        }

        [HttpGet("cdata")]
        public string GetCdata()
        {
            return "OK";
        }

        [HttpPost("cdata")]
        public async Task<IActionResult> PostData()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body))
                {
                    string body = await reader.ReadToEndAsync();
                    // Cambiamos "SN" a minúsculas para que sea insensible a mayúsculas y minúsculas.
                    string sn = HttpContext.Request.Query["SN"].ToString().ToLower();

                    string[] expectedKeys = { "time", "pin", "cardno", "eventaddr", "event", "inoutstatus", "verifytype", "index" };

                    var keyValuePairs = body.Split('\t').Select(kv => kv.Split('='));

                    var data = new Dictionary<string, string>();                 
                    foreach (var keyValue in keyValuePairs)
                    {
                        if (keyValue.Length == 2)
                        {
                            data[keyValue[0]] = keyValue[1];
                        }
                    }
                    if (expectedKeys.All(key => data.ContainsKey(key)))
                    {
                        var verifyTypeValue = data["verifytype"];
                        int verifyTypeValue_ = Convert.ToInt32(data["verifytype"]);
                        String Evento_ = data["event"].ToString();
                        String Cardno_ = "";
                        Logger.Info(new Exception("sn ingreso:" + data["cardno"].ToString()));
                        if (data["cardno"].ToString() != "" && data["cardno"]!=null)
                        {
                            Utils utils = new Utils();
                            Cardno_ =(Convert.ToString(utils.ToDecimalAuto(data["cardno"].ToString()))).Length == 7 ? Convert.ToString(utils.ToDecimalAuto(data["cardno"].ToString())) : "";
                            Logger.Info(new Exception("sn:" + sn + "  Cardn:" + Cardno_));
                        }
                        String Time = Convert.ToString(data["time"]);
                        String Pin = data["pin"];
                        String Eventaddr = data["eventaddr"];
                        String Evento = data["event"];
                        String Inoutstatus = data["inoutstatus"];
                        String Verifytype = verifyTypeValue;
                        String Iindex = data["index"];
                        if (int.TryParse(verifyTypeValue, out int verifyType) && verifyType == 4 && Evento_ == "27" && Cardno_!="")
                        {
                            var dato = new CDatos_RFID
                            {
                                ID=0,
                                SN = sn,
                                Time = Convert.ToDateTime(Time),
                                Pin = Pin,
                                Card = Cardno_,
                                flagProcesado = false,
                            };
                            Datos_RFIDFacade datos_RFIDFacade = new Datos_RFIDFacade();
                            bool estado = datos_RFIDFacade.Grabar(dato);
                            return Ok("OK");
                        }
                        else if (verifyTypeValue_ == 200 && (Evento_ != "20" && Evento_!= "105" && Evento_!= "214"))
                        {
                            var dato = new CDatos_RFID
                            {
                                ID = 0,
                                SN = sn,
                                Time = Convert.ToDateTime(Time),
                                Pin = Pin,
                                Card = "-1",
                                flagProcesado = false
                            };
                            Datos_RFIDFacade datos_RFIDFacade = new Datos_RFIDFacade();
                            bool estado = datos_RFIDFacade.Grabar(dato);
                            return Ok("OK");
                        }
                        else
                        {
                            return BadRequest("OK");
                        }
                    }
                    else
                    {
                        return BadRequest("OK");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.InnerException);
            }
        }

        [HttpGet("registry")]
        public string GetRegistry()
        {
            return "RegistryCode=E5S64w3liy";
        }

        [HttpPost("registry")]
        public string PostRegistry()
        {
            return "RegistryCode=E5S64w3liy";
        }

        [HttpGet("push")]
        public string GetPush()
        {
            return @"ServerVersion=3.0.1
ServerName=ADMS
PushVersion=3.0.1
ErrorDelay=60
RequestDelay=2
TransTimes=00:00;14:00
TransInterval=1
TransTables=User	Transaction
Realtime=1
SessionID=90e868fffe9e8dc7-00003c14-0000003c-fbd84e529b99135c-bd413ef1
TimeoutSec=10
QRCodeDecryptKey=1d3d256332540820f9f54315de6bfde8
QRCodeDecryptType=2";
        }

        [HttpPost("push")]
        public string PostPush()
        {
            return "OK";
        }

        [HttpGet("getrequest")]
        public IActionResult GetComandosEstadoCero([FromQuery] string SN)
        {
            try
            {
                ComandosFacade comandoEstado = new ComandosFacade();
                Comandos comando = new Comandos();
                comando = comandoEstado.Recuperar(SN);
                if (comando != null)
                {
                    if (comando.sn == SN)
                    {
                        comando.estado = "1";
                        comandoEstado.Grabar(comando);
                        return Ok(comando.comando);
                    }
                    else
                    {
                        return Ok("OK");
                    }
                }
                else
                {
                    return NotFound("OK");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpGet("devicecmd")]
        public string GetDeviceCmd()
        {
            return "OK";
        }

        [HttpPost("devicecmd")]
        public string PostDeviceCmd()
        {
            return "OK";
        }

        [HttpGet("leer-datos")]
        public async Task<IActionResult> LeerDatos()
        {
            try
            {
                // Realiza una consulta para obtener todos los datos de la entidad Dato.
                Datos_RFIDFacade dato_Rfid_PasoFacade = new Datos_RFIDFacade();
                var Lista = dato_Rfid_PasoFacade.Listar();

                // Verifica si se encontraron datos.
                if (Lista != null)
                {
                    return Ok(Lista);
                }
                else
                {
                    // No se encontraron datos.
                    return NotFound("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpGet("leer-comandos")]
        public async Task<IActionResult> LeerComandos()
        {
            try
            {
                //var comandos = await _context.Comandos.ToListAsync();
                ComandosFacade comandosFacade = new ComandosFacade();
                var comando = comandosFacade.Listar();
                if (comando.Count > 0)
                {
                    // Procesa y devuelve los comandos como sea necesario.
                    return Ok(comando);
                }
                else
                {
                    return NotFound("No se encontraron comandos.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpPost("comando")]
        public async Task<IActionResult> InsertarComando([FromQuery] string SN, [FromQuery] string Comando)
        {
            try
            {
                // Crea una nueva instancia de Comandos con los valores proporcionados.
                var nuevoComando = new Comandos
                {
                    sn = SN,
                    comando = Comando,
                    estado = "0" // Establece el estado en 0 como valor predeterminado.
                };
                ComandosFacade comandofacade = new ComandosFacade();
                comandofacade.Grabar(nuevoComando);
                Logger.Info(new Exception("sn:" + SN + "  Comando:" + Comando + " Estado:" + 0));
                return Ok("true");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "false" + ex.Message);
            }
        }
    }
}
