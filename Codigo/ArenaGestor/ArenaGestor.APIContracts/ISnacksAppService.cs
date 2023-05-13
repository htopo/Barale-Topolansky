using ArenaGestor.APIContracts.Snacks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.APIContracts
{
    public interface ISnacksAppService
    {
        IActionResult PostSnack(SnackInsertSnackDto insertSnack);
        IActionResult DeleteSnack(string snackName);
        IActionResult GetSnacks();
    }
}
