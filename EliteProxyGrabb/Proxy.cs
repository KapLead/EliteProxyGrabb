namespace EliteProxyGrabb
{
    public class Proxy
    {
        public string Ip;
        public string Port;
        public string Country;
        public string Level;
        public string HostName;
        public string Protocol;
        public string LastCheckData;
        public string Number="0";
        public override string ToString() => $"{Ip}:{Port} / {Protocol} ({Country}) {Level} {HostName}".Trim();
    }
}
