using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHI.Database
{
    public class Subscription
    {
        private int fHabboID;
        public virtual int habbo_id
        {
            get { return this.fHabboID; }
            set
            {
                this.fHabboID = value;
            }
        }
        
        private int fTotalBought;
        public virtual int total_bought
        {
            get { return this.fTotalBought; }
            set
            {
                this.fTotalBought = value;
            }
        }
        private int fSkippedLength;
        public virtual int skipped_length
        {
            get { return this.fSkippedLength; }
            set
            {
                this.fSkippedLength = value;
            }
        }
        private int fPausedStart;
        public virtual int paused_start
        {
            get { return this.fPausedStart; }
            set
            {
                this.fPausedStart = value;
            }
        }
    }
}
