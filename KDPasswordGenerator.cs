    class KDPasswordGenerator

	{
        public static string EncryPassword(string password)
		{
            // K3 WISE 14.2.0 测试通过
            StringBuilder sb = new StringBuilder();
			sb.Append(")  F \", ,P T #8 *P!D &D 80!N &@ <0 C '< : !M &4 )0");
            Dictionary<char, string[]> dictionary = new Dictionary<char, string[]>
            {
                { '0', new string[] { " P ", "#  ", ",  ", "P ", "#  ", ",  " } },
                { '1', new string[] { " Q ", "#$ ", ",0 ", "Q ", "#$ ", ",0 " } },
                { '2', new string[] { " R ", "#( ", ",@ ", "R ", "#( ", ",@ " } },
                { '3', new string[] { " S ", "#, ", ",P ", "S ", "#, ", ",P " } },
                { '4', new string[] { " T ", "#0 ", "-  ", "T ", "#0 ", "-  " } },
                { '5', new string[] { " U ", "#4 ", "-0 ", "U ", "#4 ", "-0 " } },
                { '6', new string[] { " V ", "#8 ", "-@ ", "V ", "#8 ", "-@ " } },
                { '7', new string[] { " W ", "#< ", "-P ", "W ", "#< ", "-P " } },
                { '8', new string[] { " X ", "#@ ", ".  ", "X ", "#@ ", ".  " } },
                { '9', new string[] { " Y ", "#D ", ".0 ", "Y ", "#D ", ".0 " } },
                { 'a', new string[] { "!A ", "&$ ", "80", "!A ", "&$ ", "80" } },
                { 'b', new string[] { "!B ", "&( ", "8@", "!B ", "&( ", "8@" } },
                { 'c', new string[] { "!C ", "&, ", "8P", "!C ", "&, ", "8P" } },
                { 'd', new string[] { "!D ", "&0 ", "9 ", "!D ", "&0 ", "9 " } },
                { 'e', new string[] { "!E ", "&4 ", "90", "!E ", "&4 ", "90" } },
                { 'f', new string[] { "!F ", "&8 ", "9@", "!F ", "&8 ", "9@" } },
                { 'g', new string[] { "!G ", "&< ", "9P", "!G ", "&< ", "9P" } },
                { 'h', new string[] { "!H ", "&@ ", ": ", "!H ", "&@ ", ": " } },
                { 'i', new string[] { "!I ", "&D ", ":0", "!I ", "&D ", ":0" } },
                { 'j', new string[] { "!J ", "&H ", ":@", "!J ", "&H ", ":@" } },
                { 'k', new string[] { "!K ", "&L ", ":P", "!K ", "&L ", ":P" } },
                { 'l', new string[] { "!L ", "&P ", "; ", "!L ", "&P ", "; " } },
                { 'm', new string[] { "!M ", "&T ", ";0", "!M ", "&T ", ";0" } },
                { 'n', new string[] { "!N ", "&X ", ";@", "!N ", "&X ", ";@" } },
                { 'o', new string[] { "!O ", "&\\ ", ";P", "!O ", "&\\ ", ";P" } },
                { 'p', new string[] { "!P ", "'  ", "< ", "!P ", "'  ", "< " } },
                { 'q', new string[] { "!Q ", "'$ ", "<0", "!Q ", "'$ ", "<0" } },
                { 'r', new string[] { "!R ", "'( ", "<@", "!R ", "'( ", "<@" } },
                { 's', new string[] { "!S ", "', ", "<P", "!S ", "', ", "<P" } },
                { 't', new string[] { "!T ", "'0 ", "= ", "!T ", "'0 ", "= " } },
                { 'u', new string[] { "!U ", "'4 ", "=0", "!U ", "'4 ", "=0" } },
                { 'v', new string[] { "!V ", "'8 ", "=@", "!V ", "'8 ", "=@" } },
                { 'w', new string[] { "!W ", "'< ", "=P", "!W ", "'< ", "=P" } },
                { 'x', new string[] { "!X ", "'@ ", "> ", "!X ", "'@ ", "> " } },
                { 'y', new string[] { "!Y ", "'D ", ">0", "!Y ", "'D ", ">0" } },
                { 'z', new string[] { "!Z ", "'H ", ">@", "!Z ", "'H ", ">@" } },
                { 'A', new string[] { "!! ", "$$ ", "00", "!! ", "$$ ", "00" } },
                { 'B', new string[] { "!\" ", "$(", "0@", "!\" ", "$( ", "0@" } },
                { 'C', new string[] { "!# ", "$, ", "0P", "!# ", "$, ", "0P" } },
                { 'D', new string[] { "!$ ", "$0 ", "1 ", "!$ ", "$0 ", "1 " } },
                { 'E', new string[] { "!% ", "$4 ", "10", "!% ", "$4 ", "10" } },
                { 'F', new string[] { "!& ", "$8 ", "1@", "!& ", "$8 ", "1@" } },
                { 'G', new string[] { "!' ", "$< ", "1P", "!' ", "$< ", "1P" } },
                { 'H', new string[] { "!( ", "$@ ", "2 ", "!( ", "$@ ", "2 " } },
                { 'I', new string[] { "!) ", "$D ", "20", "!) ", "$D ", "20" } },
                { 'J', new string[] { "!* ", "$H ", "2@", "!* ", "$H ", "2@" } },
                { 'K', new string[] { "!+ ", "$L ", "2P", "!+ ", "$L ", "2P" } },
                { 'L', new string[] { "!, ", "$P ", "3 ", "!, ", "$P ", "3 " } },
                { 'M', new string[] { "!- ", "$T ", "30", "!- ", "$T ", "30" } },
                { 'N', new string[] { "!. ", "$X ", "3@", "!. ", "$X ", "3@" } },
                { 'O', new string[] { "!/ ", "$\\ ", "3P", "!/ ", "$\\ ", "3P" } },
                { 'P', new string[] { "!0 ", "%  ", "4 ", "!0 ", "%  ", "4 " } },
                { 'Q', new string[] { "!1 ", "%$ ", "40", "!1 ", "%$ ", "40" } },
                { 'R', new string[] { "!2 ", "%( ", "4@", "!2 ", "%( ", "4@" } },
                { 'S', new string[] { "!3 ", "%, ", "4P", "!3 ", "%, ", "4P" } },
                { 'T', new string[] { "!4 ", "%0 ", "5 ", "!4 ", "%0 ", "5 " } },
                { 'U', new string[] { "!5 ", "%4 ", "50", "!5 ", "%4 ", "50" } },
                { 'V', new string[] { "!6 ", "%8 ", "5@", "!6 ", "%8 ", "5@" } },
                { 'W', new string[] { "!7 ", "%< ", "5P", "!7 ", "%< ", "5P" } },
                { 'X', new string[] { "!8 ", "%@ ", "6 ", "!8 ", "%@ ", "6 " } },
                { 'Y', new string[] { "!9 ", "%D ", "60", "!9 ", "%D ", "60" } },
                { 'Z', new string[] { "!: ", "%H ", "6@", "!: ", "%H ", "6@" } },
                { '!', new string[] { " A ", "\"$ ", "(0", " A ", "\"$ ", "(0" } },
                { '@', new string[] { " ! ", "$  ", "0 ", " ! ", "$  ", "0 " } },
                { '#', new string[] { " C ", "\", ", "(P", " C ", "\", ", "(P" } },
                { '$', new string[] { " D ", "\"0 ", ") ", " D ", "\"0 ", ") " } },
                { '%', new string[] { " E ", "\"4 ", ")0", " E ", "\"4 ", ")0" } },
                { '^', new string[] { "!> ", "%X ", "7@", "!> ", "%X ", "7@" } },
                { '&', new string[] { " F ", "\"8 ", ")@", " F ", "\"8 ", ")@" } },
                { '*', new string[] { " J ", "\"H ", "*@", " J ", "\"H ", "*@" } },
                { '(', new string[] { " H ", "\"@ ", "* ", " H ", "\"@ ", "* " } },
                { ')', new string[] { " I ", "\"D ", "*0", " I ", "\"D ", "*0" } },
                { '_', new string[] { "!? ", "%\\ ", "7P", "!? ", "%\\ ", "7P" } },
                { '+', new string[] { " K ", "\"L ", "* P", " K ", "\"L ", "*P" } },
                { '=', new string[] { " ] ", "#T ", "/0", " ] ", "#T ", "/0" } },
                { '-', new string[] { " M ", "\"T ", "+0", " M ", "\"T ", "+0" } },
                { '[', new string[] { "!; ", "%L ", "6P", "!; ", "%L ", "6P" } },
                { ']', new string[] { "!= ", "%T ", "70", "!= ", "%T ", "70" } },
                { '{', new string[] { "![ ", "'L ", ">P", "![ ", "'L ", ">P" } },
                { '}', new string[] { "!] ", "'T ", "?0", "!] ", "'T ", "?0" } },
                { ';', new string[] { " [ ", "#L ", ".P", " [ ", "#L ", ".P" } },
                { ':', new string[] { " Z ", "#H ", ".@", " Z ", "#H ", ".@" } },
                { '"', new string[] { " B ", "\"( ", "(@", " B ", "\"( ", "(@" } },
                { '\'', new string[] { " G ", "\"< ", ")P", " G ", "\"< ", ")P" } },
                { ',', new string[] { " L ", "\"P ", "+ ", " L ", "\"P ", "+ " } },
                { '.', new string[] { " N ", "\"X ", "+@", " N ", "\"X ", "+@" } },
                { '?', new string[] { " _ ", "#\\ ", "/P", " _ ", "#\\ ", "/P" } },
                { '\\', new string[] { "!< ", "%P ", "7 ", "!< ", "%P ", "7 " } },
                { '|', new string[] { "!\\ ", "'P ", "? ", "!\\ ", "'P ", "? " } },
                { '/', new string[] { " 0 ", "\"\\", "+P", " 0 ", "\"\\", "+P" } },
                { '`', new string[] { "!@ ", "&  ", "8 ", "!@ ", "&  ", "8 " } },
                { '~', new string[] { "!^ ", "'X ", "?@", "!^ ", "'X ", "?@" } },
                { '<', new string[] { " \\ ", "#P ", "/ ", " \\ ", "#P ", "/ " } },
                { '>', new string[] { " ^ ", "#X ", "/@", " ^ ", "#X ", "/@" } }
            };

            int index = 0;
			int i = 0;
			foreach (char ch in password)
			{
				if (index >=6)index = 0;
                if (!dictionary.ContainsKey(ch))
                {
                    return "";
                }
				if (index == 3
                    && char.IsDigit(password[i])
                    && !char.IsDigit(password[i-1]) )
                {//第3/9/12..码是数字，前一码不是数字时，第3码改用第0列对照码 (0码开始)
					sb.Append(dictionary[ch][0]);
                }
                else if (i%6 == 0 && i > 0
                    && char.IsDigit(password[i])
                    && char.IsDigit(password[i-1]) )
                {//第6/12/18..码是数字，前一码也是数字时，第6码改用第3列对照码
					sb.Append(dictionary[ch][3]);
                }
                else if (i%3 == 0 && i > 0
                    && !char.IsDigit(password[i])
                    && char.IsDigit(password[i-1]) )
                {//第3\6\9..码不是数字，前一码是数字时，删除上一个空格
					sb.Remove(sb.Length - 1, 1);
					sb.Append(dictionary[ch][index]);
                }
                else
                {
					sb.Append(dictionary[ch][index]);
                }
				index++;
				i++;
			}
			return sb.ToString();
		}
	}