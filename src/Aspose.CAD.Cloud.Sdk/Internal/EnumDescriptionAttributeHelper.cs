// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EnumDescriptionAttributeHelper.cs">
//   Copyright (c) 2018 Aspose.CAD for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.CAD.Cloud.Sdk
{
    using System;
#if NETSTANDARD1_6
    using System.Linq;
    using System.Reflection;    
#endif

    internal static class EnumDescriptionAttributeHelper
    {        
        public static string GetDescription(Enum e)
        {
            if (e == null)
            {
                return string.Empty;
            }

#if NET20
            var descriptionAttribute =
                (EnumDescriptionAttribute)e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(EnumDescriptionAttribute), false)[0];
#endif
#if NETSTANDARD1_6
             var descriptionAttribute =
                (EnumDescriptionAttribute)e.GetType().GetTypeInfo().GetField(e.ToString()).GetCustomAttributes(typeof(EnumDescriptionAttribute), false).First();
#endif

            if (descriptionAttribute != null)
            {
                return descriptionAttribute.Description;
            }
        
            return string.Empty;
        }
    }
}