﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGM.IO
{
    public static class VertexFormatFunctions
    {
		[GMLFunction("vertex_format_begin", GMLFunctionFlags.Stub)]
	    public static object? vertex_format_begin(object?[] args)
	    {
		    return null;
	    }

		// vertex_format_delete

		[GMLFunction("vertex_format_end", GMLFunctionFlags.Stub)]
		public static object? vertex_format_end(object?[] args)
		{
			return null;
		}

		[GMLFunction("vertex_format_add_position", GMLFunctionFlags.Stub)]
		public static object? vertex_format_add_position(object?[] args)
		{
			return null;
		}

		// vertex_format_add_position_3d

		[GMLFunction("vertex_format_add_color", GMLFunctionFlags.Stub)]
		[GMLFunction("vertex_format_add_colour", GMLFunctionFlags.Stub)]
		public static object? vertex_format_add_colour(object?[] args)
		{
			return null;
		}

		[GMLFunction("vertex_format_add_normal", GMLFunctionFlags.Stub)]
		public static object? vertex_format_add_normal(object?[] args)
		{
			return null;
		}

		// vertex_format_add_textcoord
		// vertex_format_add_texcoord
		// vertex_format_add_custom
	}
}
