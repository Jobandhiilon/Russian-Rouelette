using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouelette
{
    [TestFixture]
    class UnitTesting
    {
        [TestCase]
        public void Shot_Positive()
        {
            Play Shot_pos = new Play();
            Assert.AreEqual(10, Shot_pos.Shotbullet(1, 1));
        }

        [TestCase]
        public void Spin()
        {
            russian spin = new russian();
            Assert.AreEqual(6, spin.Spin_chamber(5));
        }
    }
}
