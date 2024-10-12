public class TimeMap {

    Dictionary<string, List<(string value, int timestamp)>> dict;

    public TimeMap() {
        dict = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, new List<(string value, int timestamp)>());
        }
        dict[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        string ans = "";
        
        if (dict.TryGetValue(key, out var list))
        {
            if (list.Count == 1)
            {
                if (list[0].timestamp <= timestamp)
                {
                    return list[0].value;
                }
                else
                {
                    return ans;
                }
            }
            if (list.Count == 2)
            {
                if (list[1].timestamp <= timestamp)
                {
                    return list[1].value;
                }
                else if (list[0].timestamp <= timestamp)
                {
                    return list[0].value;
                }
                else
                {
                    return ans;
                }
            }
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (list[mid].timestamp == timestamp)
                {
                    return list[mid].value;
                }
                else if (list[mid].timestamp < timestamp)
                {
                    left = mid + 1;
                }
                else if (list[mid].timestamp > timestamp)
                {
                    right = mid - 1;
                }
                else
                {
                    return list[mid].value;
                }
            }
            if (list[right].timestamp < timestamp)
            {
                return list[right].value;
            }
        }
        return ans;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
