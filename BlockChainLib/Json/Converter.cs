using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BlockChainLib.Json
{
    internal class DateTimeConverter : DateTimeConverterBase
    {
        private static DateTime epoch { get; } = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static DateTime GenesisBlockDate { get; } = DateTimeConverter.UnixSecondsToDateTime(1231006505);
        public const long GenesisBlockUnixMillis = 1231006505000;
        private bool convertFromMillis { get; }
        public DateTimeConverter() { }
        public DateTimeConverter(bool convertFromMillis)
        {
            this.convertFromMillis = convertFromMillis;
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object value = reader.Value;
            if (reader.Value is long)
            {
                value = (double)(long)value;
            }
            else if (reader.Value is string)
            {
                double doubleValue;
                if (double.TryParse((string)value, out doubleValue))
                {
                    value = doubleValue;
                }
            }
            if (value is double)
            {
                return this.convertFromMillis
                    ? DateTimeConverter.UnixMillisToDateTime((double)value)
                    : DateTimeConverter.UnixSecondsToDateTime((double)value);
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime)
            {
                double unixTimestamp = DateTimeConverter.DateTimeToUnixSeconds((DateTime)value);
                if (this.convertFromMillis)
                {
                    unixTimestamp *= 1000d;
                }
                writer.WriteRawValue(unixTimestamp.ToString());
            }
        }
        internal static double DateTimeToUnixSeconds(DateTime dateTime)
        {
            return (dateTime - DateTimeConverter.epoch).TotalSeconds;
        }

        private static DateTime UnixSecondsToDateTime(double unixSeconds)
        {
            return DateTimeConverter.UnixMillisToDateTime(unixSeconds * 1000d);
        }

        private static DateTime UnixMillisToDateTime(double unixMillis)
        {
            DateTime dateTime = DateTimeConverter.epoch.AddMilliseconds(unixMillis);
            if (dateTime < DateTimeConverter.GenesisBlockDate)
            {
                throw new ArgumentOutOfRangeException(nameof(unixMillis),
                    "No date can be before the genesis block (2009-01-03T18:15:05+00:00)");
            }
            return dateTime;
        }
    }
}
