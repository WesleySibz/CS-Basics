using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type | Represents | Range | Default Value
        bool / Boolean value:  True or False                       False
        byte        8 - bit unsigned integer                  0 to 255                            0

        char        16 - bit Unicode character                U + 0000 to U +ffff                  '\0'

        decimal     128 - bit precise decimal values(-7.9 x 1028 to 7.9 x 1028) 		0.0M
            with 28 - 29 significant digits           / 100 to 28

        double      64 - bit double-precision floating(+/ -)5.0 x 10 - 324                   0.0D
            point type                              to(+/ -)1.7 x 10308

        float       32 - bit single - precision floating - 3.4 x 1038 to + 3.4 x 1038         0.0F
            point type

        int         32 - bit signed integer type - 2,147,483,648 to 2,147,483,647     0

        long        64 - bit signed integer type - 9,223,372,036,854,775,808          0L
            to 9,223,372,036,854,775,807

        sbyte       8 - bit signed integer type - 128 to 127                         0

        short       16 - bit signed integer type - 32,768 to 32,767                   0

        uint        32 - bit unsigned integer type            0 to 4,294,967,295                  0

        ulong       64 - bit unsigned integer type            0 to 18,446,744,073,709,551,615     0

        ushort      16 - bit unsigned integer type            0 to 65,535                         0
            
            short s1 = -32768;

            short s2 = 32767;

            short s3 = 35000;
            //Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;

            ushort us2 = -32000; 
            //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine(Int16.MaxValue);
            //32767
            
            Console.WriteLine(Int16.MinValue);
            //-32768
            
            Console.WriteLine(UInt16.MaxValue);
            //65535
            
            Console.WriteLine(UInt16.MinValue);
            //0
            */
        }
    }
}
