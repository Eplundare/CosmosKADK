using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVideoManager : MonoBehaviour
{
    [System.Flags]
    private enum Students : int
    {
        //VK
        fVK1 = 1 << 0,
        fVK2 = 1 << 1,
        fVK3 = 1 << 2,
        fVK4 = 1 << 3,
        fVK5 = 1 << 4,
        fVK6 = 1 << 5,
        fVK7 = 1 << 6,
        fVK8 = 1 << 7,
        fVK9 = 1 << 8,
        fVK10 = 1 << 9,
        fVK11 = 1 << 10,
        fVK12 = 1 << 11,
        fVK13 = 1 << 12,
        fVK14 = 1 << 13,
        fVK15 = 1 << 14,
        fVK16 = 1 << 15,
        fVK17 = 1 << 16,
        fVK18 = 1 << 17,
        fVK19 = 1 << 18,
        fVK20 = 1 << 19,
        fVK21 = 1 << 20,
        fVK22 = 1 << 21,
        
        //BT
        fBT1 = 1 << 22,
        fBT2 = 1 << 23,
        fBT3 = 1 << 24,
        fBT4 = 1 << 25,
        fBT5 = 1 << 26,
        fBT6 = 1 << 27,
        fBT7 = 1 << 28,
        fBT8 = 1 << 29,
        fBT9 = 1 << 30,
        fBT10 = 1 << 31,
        fBT11 = 1 << 32,
        fVBT12 = 1 << 33,
        fVBT13 = 1 << 34,
        fBT14 = 1 << 35,
        fBT15 = 1 << 36,

        //SI
        fSI1 = 1 << 37,
        fSI2 = 1 << 38,
        fSI3 = 1 << 39,
        fSI4 = 1 << 40,
        fSI5 = 1 << 41,
        fSI6 = 1 << 42,
        fSI7 = 1 << 43,
        fSI8 = 1 << 44,
        fSI9 = 1 << 45,
        fSI10 = 1 << 46,
        fSI11 = 1 << 47,
        fSI12 = 1 << 48,

        //MRM
        fMRM1 = 1 << 49,
        fMRM2 = 1 << 50,
        fMRM3 = 1 << 51,
        fMRM4 = 1 << 52,
        fMRM5 = 1 << 53,
        fMRM6 = 1 << 54,
        fMRM7 = 1 << 55,
        fMRM8 = 1 << 56,
        fMRM9 = 1 << 57,
        fMRM10 = 1 << 58,
        fMRM11 = 1 << 59,
        fMRM12 = 1 << 60,
        fMRM13 = 1 << 61,
        fMRM14 = 1 << 62,
        fMRM15 = 1 << 63,
        fMRM16 = 1 << 64,
        fMRM17 = 1 << 65,
        fMRM18 = 1 << 66,
        fMRM19 = 1 << 67,
        fMRM20 = 1 << 68,
        fMRM21 = 1 << 69,
        fMRM22 = 1 << 70,
        fMRM23 = 1 << 71

    }

    private Students currentStudent;

    public StudentMedia[] vkStudent;
    public StudentMedia[] btStudent;
    public StudentMedia[] siStudent;
    public StudentMedia[] mrmStudent;

}
