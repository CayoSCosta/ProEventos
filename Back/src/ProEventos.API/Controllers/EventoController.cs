﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {

    public EventoController()
    {

    }

    [HttpGet]
    public string Get()
    {
      return "Olá senhor Cayo";
    }

    [HttpPost]
    public string Post()
    {
      return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Exemplo de put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Exemplo de delete com id = {id}";
    }
  }
}