#region netDxf library, Copyright (C) 2009-2019 Daniel Carvajal (haplokuon@gmail.com)

//                        netDxf library
// Copyright (C) 2009-2019 Daniel Carvajal (haplokuon@gmail.com)
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#endregion

namespace netDxf.Header
{
    /// <summary>
    /// The AutoCAD drawing database version number.
    /// </summary>
    public enum DxfVersion
    {
        /// <summary>
        /// Unknown AutoCAD DXF file.
        /// </summary>
        [StringValue("Unknown")]
        Unknown = 0,

        /// <summary>
        /// AutoCAD R10 DXF file. AutoCAD release 10.
        /// </summary>
        [StringValue("AC1006")]
        AutoCad10 = 1,

        /// <summary>
        /// AutoCAD R11 and R12 DXF file. AutoCAD release 11/12 (LT R1/R2).
        /// </summary>
        [StringValue("AC1009")]
        AutoCad12 = 2,

        /// <summary>
        /// AutoCAD R13 DXF file. AutoCAD release 13 (LT95).
        /// </summary>
        [StringValue("AC1012")]
        AutoCad13 = 3,

        /// <summary>
        /// AutoCAD R14 DXF file. AutoCAD release 14, 14.01 (LT97/LT98).
        /// </summary>
        [StringValue("AC1014")]
        AutoCad14 = 4,

        /// <summary>
        /// AutoCAD 2000 DXF file. AutoCAD 2000/2000i/2002.
        /// </summary>
        [StringValue("AC1015")]
        AutoCad2000 = 5,

        /// <summary>
        /// AutoCAD 2004 DXF file. AutoCAD 2004/2005/2006.
        /// </summary>
        [StringValue("AC1018")]
        AutoCad2004 = 6,

        /// <summary>
        /// AutoCAD 2007 DXF file. AutoCAD 2007/2008/2009.
        /// </summary>
        [StringValue("AC1021")]
        AutoCad2007 = 7,

        /// <summary>
        /// AutoCAD 2010 DXF file. AutoCAD 2010/2011/2012.
        /// </summary>
        [StringValue("AC1024")]
        AutoCad2010 = 8,

        /// <summary>
        /// AutoCAD 2013 DXF file. AutoCAD 2013/2014/2015/2016/2017.
        /// </summary>
        [StringValue("AC1027")]
        AutoCad2013 = 9,

        /// <summary>
        /// AutoCAD 2018 DXF file. AutoCAD 2018/2019/2020.
        /// </summary>
        [StringValue("AC1032")]
        AutoCad2018 = 10
    }
}