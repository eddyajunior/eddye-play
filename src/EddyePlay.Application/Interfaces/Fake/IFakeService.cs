using EddyePlay.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyePlay.Application.Interfaces.Fake
{
    public interface IFakeService
    {
        PersonEntity Generate();
    }
}
