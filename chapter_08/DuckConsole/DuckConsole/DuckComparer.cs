using System;
using System.Collections.Generic;
using System.Text;

namespace DuckConsole
{
    public class DuckComparer : IComparer<Duck>
    {
        public ESortCriteria SortBy = ESortCriteria.SizeThenKind;
        public int Compare(Duck x, Duck y)
        {
            if(SortBy == ESortCriteria.SizeThenKind) {
                if(x.Size < y.Size)
                {
                    return -1;
                }
                else if(x.Size > y.Size)
                {
                    return 1;
                }
                else
                {
                    if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            else
            {
                if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else
                {
                    if(x.Size < y.Size)
                    {
                        return -1;
                    }
                    else if(x.Size > y.Size)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
