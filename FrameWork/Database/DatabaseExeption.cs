﻿/*
 * Copyright (C) 2013 APS
 *	http://AllPrivateServer.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
 
using System;

namespace FrameWork
{
    public class DatabaseException : ApplicationException
    {
        // Exeption levé par la database
        public DatabaseException(Exception e)
            : base("", e)
        {
        }

        // Lèvre un exeption avec le message d'erreur
        public DatabaseException(string str, Exception e)
            : base(str, e)
        {
        }

        // Raisons de l'exeption
        public DatabaseException(string str)
            : base(str)
        {
        }
    }
}