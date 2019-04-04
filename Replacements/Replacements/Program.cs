using System;
using System.Linq;
using ModernCR;

namespace Replacements
{
    class Program
    {
        static void Main(string[] args)
        {
            var cr = new RunCrystal();
            cr.BuildReport("D:\\Programs\\Replacement\\Replacements.rpt", "D:\\Programs\\Replacement\\Replacements.pdf");

            cr.SetToAddress("k.mitchell@teammodern.com");
            cr.SetToAddress("j.lyons@teammodern.com");

            cr.SetSubject("Replacements " + DateTime.Now.ToString("MM-dd"));
            cr.SetAttachments("D:\\Programs\\Replacement\\Replacements.pdf");
            cr.SendEmail();
        }
    }
}