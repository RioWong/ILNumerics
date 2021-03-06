#region Copyright GPLv3
//
//  This file is part of ILNumerics.Net. 
//
//  ILNumerics.Net supports numeric application development for .NET 
//  Copyright (C) 2007, H. Kutschbach, http://ilnumerics.net 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//  Non-free licenses are also available. Contact info@ilnumerics.net 
//  for details.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; 

namespace ILNumerics.Drawing.Misc {
    public abstract class ILAction {

        #region attributes
        TimeSpan m_duration; 
        Thread m_workerThread; 
        protected bool m_canceled; 
        #endregion

        #region properties
        #endregion

        #region constructor
        public ILAction() {
            m_canceled = false; 
            m_workerThread = new Thread(new ParameterizedThreadStart(RunInternal)); 
        }
        #endregion

        #region public interface 
        // Run
        public void Run() {
            if (m_workerThread.ThreadState != ThreadState.Running) {
                m_canceled = false; 
                m_workerThread.Start();
            }
        }
        // Cancel
        public void Cancel() {
            m_canceled = true; 
        }

        protected abstract void RunInternal(object parameter); 
        #endregion 

        #region private helper

        #endregion
    }
}
