using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Calculations
    {
    public Calculations()
    {

    }

    public double Q_t(double U_t, double C_t, double Z_t)
    {
        return U_t + C_t + Z_t;
    }

    public double Kp(double Zv, double GKR, double VMP, double RKP)
    {
        return (Zv + GKR - VMP)/RKP;
    }

    public double ChGPp(double ChGPo, double ChGPi, double ChGPf)
    {
        return ChGPo + ChGPi + ChGPf;
    }

}

