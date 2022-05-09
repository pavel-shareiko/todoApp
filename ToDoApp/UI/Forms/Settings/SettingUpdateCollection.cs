using System;
using System.Collections.Generic;

namespace ToDoApp.Forms
{
    public class SettingUpdateCollection : HashSet<SettingUpdate>
    {
        public bool Contains(Predicate<SettingUpdate> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (var settingUpdate in this)
            {
                if (predicate(settingUpdate))
                {
                    return true;
                }
            }

            return false;
        }

        public new void Add(SettingUpdate item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var duplicate = FirstOrNull(update => update.Control == item.Control);
            if (duplicate != null)
            {
                Remove(duplicate);
            }

            base.Add(item);
        }

        public SettingUpdate FirstOrNull(Predicate<SettingUpdate> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (var update in this)
            {
                if (predicate(update))
                {
                    return update;
                }
            }

            return null;
        }
    }
}
