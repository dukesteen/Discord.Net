﻿using System;

namespace Discord
{
    /*internal class Reference<T>
        where T : CachedObject<ulong>
    {
        private Action<T> _onCache, _onUncache;
        private Func<ulong, T> _getItem;
        private ulong? _id;
        public ulong? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                _value = null;
            }
        }

        private T _value;
        public T Value
        {
            get
            {
            }
        }

        public T Load()
        {
            var v = _value; //A little trickery to make this threadsafe
            var id = _id;
            if (v != null && !_value.IsCached)
            {
                v = null;
                _value = null;
            }
            if (v == null && id != null)
            {
                v = _getItem(id.Value);
                if (v != null && _onCache != null)
                    _onCache(v);
                _value = v;
            }
            return v;
            return Value != null; //Used for precaching
        }

        public void Unload()
        {
            if (_onUncache != null)
            {
                var v = _value;
                if (v != null && _onUncache != null)
                    _onUncache(v);
            }
        }

        public Reference(Func<ulong, T> onUpdate, Action<T> onCache = null, Action<T> onUncache = null)
            : this(null, onUpdate, onCache, onUncache)
        { }
        public Reference(ulong? id, Func<ulong, T> getItem, Action<T> onCache = null, Action<T> onUncache = null)
        {
            _id = id;
            _getItem = getItem;
            _onCache = onCache;
            _onUncache = onUncache;
            _value = null;
        }
    }*/
}
