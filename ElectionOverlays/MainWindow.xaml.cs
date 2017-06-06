using ElectionOverlays.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectionOverlays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        internal Dictionary<string, Color> PartyColors = new Dictionary<string, Color>();
        internal Dictionary<string, string> CurrentParties = new Dictionary<string, string>();

        internal RenderWindow render = null;

        private void FillCurrentData()
        {
            CurrentParties.Add("Aberavon", "LAB");
            CurrentParties.Add("Aberconwy", "CON");
            CurrentParties.Add("Aberdeen North", "SNP");
            CurrentParties.Add("Aberdeen South", "SNP");
            CurrentParties.Add("Airdrie and Shotts", "SNP");
            CurrentParties.Add("Aldershot", "CON");
            CurrentParties.Add("Aldridge-Brownhills", "CON");
            CurrentParties.Add("Altrincham and Sale West", "CON");
            CurrentParties.Add("Alyn and Deeside", "LAB");
            CurrentParties.Add("Amber Valley", "CON");
            CurrentParties.Add("Angus", "SNP");
            CurrentParties.Add("Arfon", "PC");
            CurrentParties.Add("Argyll and Bute", "SNP");
            CurrentParties.Add("Arundel and South Downs", "CON");
            CurrentParties.Add("Ashfield", "LAB");
            CurrentParties.Add("Ashford", "CON");
            CurrentParties.Add("Ashton-Under-Lyne", "LAB");
            CurrentParties.Add("Aylesbury", "CON");
            CurrentParties.Add("Ayr, Carrick and Cumnock", "SNP");
            CurrentParties.Add("Banbury", "CON");
            CurrentParties.Add("Banff and Buchan", "SNP");
            CurrentParties.Add("Barking", "LAB");
            CurrentParties.Add("Barnsley Central", "LAB");
            CurrentParties.Add("Barnsley East", "LAB");
            CurrentParties.Add("Barrow and Furness", "LAB");
            CurrentParties.Add("Basildon and Billericay", "CON");
            CurrentParties.Add("Basingstoke", "CON");
            CurrentParties.Add("Bassetlaw", "LAB");
            CurrentParties.Add("Bath", "CON");
            CurrentParties.Add("Batley and Spen", "LAB");
            CurrentParties.Add("Battersea", "CON");
            CurrentParties.Add("Beaconsfield", "CON");
            CurrentParties.Add("Beckenham", "CON");
            CurrentParties.Add("Bedford", "CON");
            CurrentParties.Add("Belfast East", "DUP");
            CurrentParties.Add("Belfast North", "DUP");
            CurrentParties.Add("Belfast South", "SDLP");
            CurrentParties.Add("Belfast West", "SF");
            CurrentParties.Add("Bermondsey and Old Southwark", "LAB");
            CurrentParties.Add("Berwickshire, Roxburgh and Selkirk", "SNP");
            CurrentParties.Add("Berwick-Upon-Tweed", "CON");
            CurrentParties.Add("Bethnal Green and Bow", "LAB");
            CurrentParties.Add("Beverley and Holderness", "CON");
            CurrentParties.Add("Bexhill and Battle", "CON");
            CurrentParties.Add("Bexleyheath and Crayford", "CON");
            CurrentParties.Add("Birkenhead", "LAB");
            CurrentParties.Add("Birmingham, Edgbaston", "LAB");
            CurrentParties.Add("Birmingham, Erdington", "LAB");
            CurrentParties.Add("Birmingham, Hall Green", "LAB");
            CurrentParties.Add("Birmingham, Hodge Hill", "LAB");
            CurrentParties.Add("Birmingham, Ladywood", "LAB");
            CurrentParties.Add("Birmingham, Northfield", "LAB");
            CurrentParties.Add("Birmingham, Perry Barr", "LAB");
            CurrentParties.Add("Birmingham, Selly Oak", "LAB");
            CurrentParties.Add("Birmingham, Yardley", "LAB");
            CurrentParties.Add("Bishop Auckland", "LAB");
            CurrentParties.Add("Blackburn", "LAB");
            CurrentParties.Add("Blackley and Broughton", "LAB");
            CurrentParties.Add("Blackpool North and Cleveleys", "CON");
            CurrentParties.Add("Blackpool South", "LAB");
            CurrentParties.Add("Blaenau Gwent", "LAB");
            CurrentParties.Add("Blaydon", "LAB");
            CurrentParties.Add("Blyth Valley", "LAB");
            CurrentParties.Add("Bognor Regis and Littlehampton", "CON");
            CurrentParties.Add("Bolsover", "LAB");
            CurrentParties.Add("Bolton North East", "LAB");
            CurrentParties.Add("Bolton South East", "LAB");
            CurrentParties.Add("Bolton West", "CON");
            CurrentParties.Add("Bootle", "LAB");
            CurrentParties.Add("Boston and Skegness", "CON");
            CurrentParties.Add("Bosworth", "CON");
            CurrentParties.Add("Bournemouth East", "CON");
            CurrentParties.Add("Bournemouth West", "CON");
            CurrentParties.Add("Bracknell", "CON");
            CurrentParties.Add("Bradford East", "LAB");
            CurrentParties.Add("Bradford South", "LAB");
            CurrentParties.Add("Bradford West", "LAB");
            CurrentParties.Add("Braintree", "CON");
            CurrentParties.Add("Brecon and Radnorshire", "CON");
            CurrentParties.Add("Brent Central", "LAB");
            CurrentParties.Add("Brentford and Isleworth", "LAB");
            CurrentParties.Add("Brent North", "LAB");
            CurrentParties.Add("Brentwood and Ongar", "CON");
            CurrentParties.Add("Bridgend", "LAB");
            CurrentParties.Add("Bridgwater and West Somerset", "CON");
            CurrentParties.Add("Brigg and Goole", "CON");
            CurrentParties.Add("Brighton, Kemptown", "CON");
            CurrentParties.Add("Brighton, Pavilion", "GRN");
            CurrentParties.Add("Bristol East", "LAB");
            CurrentParties.Add("Bristol North West", "CON");
            CurrentParties.Add("Bristol South", "LAB");
            CurrentParties.Add("Bristol West", "LAB");
            CurrentParties.Add("Broadland", "CON");
            CurrentParties.Add("Bromley and Chislehurst", "CON");
            CurrentParties.Add("Bromsgrove", "CON");
            CurrentParties.Add("Broxbourne", "CON");
            CurrentParties.Add("Broxtowe", "CON");
            CurrentParties.Add("Burnley", "LAB");
            CurrentParties.Add("Burton", "CON");
            CurrentParties.Add("Bury North", "CON");
            CurrentParties.Add("Bury South", "LAB");
            CurrentParties.Add("Bury St Edmunds", "CON");
            CurrentParties.Add("Caerphilly", "LAB");
            CurrentParties.Add("Caithness, Sutherland and Easter Ross", "SNP");
            CurrentParties.Add("Calder Valley", "CON");
            CurrentParties.Add("Camberwell and Peckham", "LAB");
            CurrentParties.Add("Camborne and Redruth", "CON");
            CurrentParties.Add("Cambridge", "LAB");
            CurrentParties.Add("Cannock Chase", "CON");
            CurrentParties.Add("Canterbury", "CON");
            CurrentParties.Add("Cardiff Central", "LAB");
            CurrentParties.Add("Cardiff North", "CON");
            CurrentParties.Add("Cardiff South and Penarth", "LAB");
            CurrentParties.Add("Cardiff West", "LAB");
            CurrentParties.Add("Carlisle", "CON");
            CurrentParties.Add("Carmarthen East and Dinefwr", "PC");
            CurrentParties.Add("Carmarthen West and South Pembrokeshire", "CON");
            CurrentParties.Add("Carshalton and Wallington", "LIB");
            CurrentParties.Add("Castle Point", "CON");
            CurrentParties.Add("Central Ayrshire", "SNP");
            CurrentParties.Add("Central Devon", "CON");
            CurrentParties.Add("Central Suffolk and North Ipswich", "CON");
            CurrentParties.Add("Ceredigion", "LIB");
            CurrentParties.Add("Charnwood", "CON");
            CurrentParties.Add("Chatham and Aylesford", "CON");
            CurrentParties.Add("Cheadle", "CON");
            CurrentParties.Add("Chelmsford", "CON");
            CurrentParties.Add("Chelsea and Fulham", "CON");
            CurrentParties.Add("Cheltenham", "CON");
            CurrentParties.Add("Chesham and Amersham", "CON");
            CurrentParties.Add("Chesterfield", "LAB");
            CurrentParties.Add("Chichester", "CON");
            CurrentParties.Add("Chingford and Woodford Green", "CON");
            CurrentParties.Add("Chippenham", "CON");
            CurrentParties.Add("Chipping Barnet", "CON");
            CurrentParties.Add("Chorley", "LAB");
            CurrentParties.Add("Christchurch", "CON");
            CurrentParties.Add("Cities Of London and Westminster", "CON");
            CurrentParties.Add("City Of Chester", "LAB");
            CurrentParties.Add("City Of Durham", "LAB");
            CurrentParties.Add("Clacton", "IND");
            CurrentParties.Add("Cleethorpes", "CON");
            CurrentParties.Add("Clwyd South", "LAB");
            CurrentParties.Add("Clwyd West", "CON");
            CurrentParties.Add("Coatbridge, Chryston and Bellshill", "SNP");
            CurrentParties.Add("Colchester", "CON");
            CurrentParties.Add("Colne Valley", "CON");
            CurrentParties.Add("Congleton", "CON");
            CurrentParties.Add("Copeland", "CON");
            CurrentParties.Add("Corby", "CON");
            CurrentParties.Add("Coventry North East", "LAB");
            CurrentParties.Add("Coventry North West", "LAB");
            CurrentParties.Add("Coventry South", "LAB");
            CurrentParties.Add("Crawley", "CON");
            CurrentParties.Add("Crewe and Nantwich", "CON");
            CurrentParties.Add("Croydon Central", "CON");
            CurrentParties.Add("Croydon North", "LAB");
            CurrentParties.Add("Croydon South", "CON");
            CurrentParties.Add("Cumbernauld, Kilsyth and Kirkintilloch East", "SNP");
            CurrentParties.Add("Cynon Valley", "LAB");
            CurrentParties.Add("Dagenham and Rainham", "LAB");
            CurrentParties.Add("Darlington", "LAB");
            CurrentParties.Add("Dartford", "CON");
            CurrentParties.Add("Daventry", "CON");
            CurrentParties.Add("Delyn", "LAB");
            CurrentParties.Add("Denton and Reddish", "LAB");
            CurrentParties.Add("Derby North", "CON");
            CurrentParties.Add("Derbyshire Dales", "CON");
            CurrentParties.Add("Derby South", "LAB");
            CurrentParties.Add("Devizes", "CON");
            CurrentParties.Add("Dewsbury", "LAB");
            CurrentParties.Add("Doncaster Central", "LAB");
            CurrentParties.Add("Doncaster North", "LAB");
            CurrentParties.Add("Don Valley", "LAB");
            CurrentParties.Add("Dover", "CON");
            CurrentParties.Add("Dudley North", "LAB");
            CurrentParties.Add("Dudley South", "CON");
            CurrentParties.Add("Dulwich and West Norwood", "LAB");
            CurrentParties.Add("Dumfries and Galloway", "SNP");
            CurrentParties.Add("Dumfriesshire, Clydesdale and Tweeddale", "CON");
            CurrentParties.Add("Dundee East", "SNP");
            CurrentParties.Add("Dundee West", "SNP");
            CurrentParties.Add("Dunfermline and West Fife", "SNP");
            CurrentParties.Add("Dwyfor Meirionnydd", "PC");
            CurrentParties.Add("Ealing Central and Acton", "LAB");
            CurrentParties.Add("Ealing North", "LAB");
            CurrentParties.Add("Ealing, Southall", "LAB");
            CurrentParties.Add("Easington", "LAB");
            CurrentParties.Add("East Antrim", "DUP");
            CurrentParties.Add("Eastbourne", "CON");
            CurrentParties.Add("East Devon", "CON");
            CurrentParties.Add("East Dunbartonshire", "SNP");
            CurrentParties.Add("East Ham", "LAB");
            CurrentParties.Add("East Hampshire", "CON");
            CurrentParties.Add("East Kilbride, Strathaven and Lesmahagow", "SNP");
            CurrentParties.Add("Eastleigh", "CON");
            CurrentParties.Add("East Londonderry", "DUP");
            CurrentParties.Add("East Lothian", "SNP");
            CurrentParties.Add("East Renfrewshire", "SNP");
            CurrentParties.Add("East Surrey", "CON");
            CurrentParties.Add("East Worthing and Shoreham", "CON");
            CurrentParties.Add("East Yorkshire", "CON");
            CurrentParties.Add("Eddisbury", "CON");
            CurrentParties.Add("Edinburgh East", "SNP");
            CurrentParties.Add("Edinburgh North and Leith", "SNP");
            CurrentParties.Add("Edinburgh South", "LAB");
            CurrentParties.Add("Edinburgh South West", "SNP");
            CurrentParties.Add("Edinburgh West", "SNP");
            CurrentParties.Add("Edmonton", "LAB");
            CurrentParties.Add("Ellesmere Port and Neston", "LAB");
            CurrentParties.Add("Elmet and Rothwell", "CON");
            CurrentParties.Add("Eltham", "LAB");
            CurrentParties.Add("Enfield North", "LAB");
            CurrentParties.Add("Enfield, Southgate", "CON");
            CurrentParties.Add("Epping Forest", "CON");
            CurrentParties.Add("Epsom and Ewell", "CON");
            CurrentParties.Add("Erewash", "CON");
            CurrentParties.Add("Erith and Thamesmead", "LAB");
            CurrentParties.Add("Esher and Walton", "CON");
            CurrentParties.Add("Exeter", "LAB");
            CurrentParties.Add("Falkirk", "SNP");
            CurrentParties.Add("Fareham", "CON");
            CurrentParties.Add("Faversham and Mid Kent", "CON");
            CurrentParties.Add("Feltham and Heston", "LAB");
            CurrentParties.Add("Fermanagh and South Tyrone", "UUP");
            CurrentParties.Add("Filton and Bradley Stoke", "CON");
            CurrentParties.Add("Finchley and Golders Green", "CON");
            CurrentParties.Add("Folkestone and Hythe", "CON");
            CurrentParties.Add("Forest Of Dean", "CON");
            CurrentParties.Add("Foyle", "SDLP");
            CurrentParties.Add("Fylde", "CON");
            CurrentParties.Add("Gainsborough", "CON");
            CurrentParties.Add("Garston and Halewood", "LAB");
            CurrentParties.Add("Gateshead", "LAB");
            CurrentParties.Add("Gedling", "LAB");
            CurrentParties.Add("Gillingham and Rainham", "CON");
            CurrentParties.Add("Glasgow Central", "SNP");
            CurrentParties.Add("Glasgow East", "SNP");
            CurrentParties.Add("Glasgow North", "SNP");
            CurrentParties.Add("Glasgow North East", "SNP");
            CurrentParties.Add("Glasgow North West", "SNP");
            CurrentParties.Add("Glasgow South", "SNP");
            CurrentParties.Add("Glasgow South West", "SNP");
            CurrentParties.Add("Glenrothes", "SNP");
            CurrentParties.Add("Gloucester", "CON");
            CurrentParties.Add("Gordon", "SNP");
            CurrentParties.Add("Gosport", "CON");
            CurrentParties.Add("Gower", "CON");
            CurrentParties.Add("Grantham and Stamford", "CON");
            CurrentParties.Add("Gravesham", "CON");
            CurrentParties.Add("Great Grimsby", "LAB");
            CurrentParties.Add("Great Yarmouth", "CON");
            CurrentParties.Add("Greenwich and Woolwich", "LAB");
            CurrentParties.Add("Guildford", "CON");
            CurrentParties.Add("Hackney North and Stoke Newington", "LAB");
            CurrentParties.Add("Hackney South and Shoreditch", "LAB");
            CurrentParties.Add("Halesowen and Rowley Regis", "CON");
            CurrentParties.Add("Halifax", "LAB");
            CurrentParties.Add("Haltemprice and Howden", "CON");
            CurrentParties.Add("Halton", "LAB");
            CurrentParties.Add("Hammersmith", "LAB");
            CurrentParties.Add("Hampstead and Kilburn", "LAB");
            CurrentParties.Add("Harborough", "CON");
            CurrentParties.Add("Harlow", "CON");
            CurrentParties.Add("Harrogate and Knaresborough", "CON");
            CurrentParties.Add("Harrow East", "CON");
            CurrentParties.Add("Harrow West", "LAB");
            CurrentParties.Add("Hartlepool", "LAB");
            CurrentParties.Add("Harwich and North Essex", "CON");
            CurrentParties.Add("Hastings and Rye", "CON");
            CurrentParties.Add("Havant", "CON");
            CurrentParties.Add("Hayes and Harlington", "LAB");
            CurrentParties.Add("Hazel Grove", "CON");
            CurrentParties.Add("Hemel Hempstead", "CON");
            CurrentParties.Add("Hemsworth", "LAB");
            CurrentParties.Add("Hendon", "CON");
            CurrentParties.Add("Henley", "CON");
            CurrentParties.Add("Hereford and South Herefordshire", "CON");
            CurrentParties.Add("Hertford and Stortford", "CON");
            CurrentParties.Add("Hertsmere", "CON");
            CurrentParties.Add("Hexham", "CON");
            CurrentParties.Add("Heywood and Middleton", "LAB");
            CurrentParties.Add("High Peak", "CON");
            CurrentParties.Add("Hitchin and Harpenden", "CON");
            CurrentParties.Add("Holborn and St Pancras", "LAB");
            CurrentParties.Add("Hornchurch and Upminster", "CON");
            CurrentParties.Add("Hornsey and Wood Green", "LAB");
            CurrentParties.Add("Horsham", "CON");
            CurrentParties.Add("Houghton and Sunderland South", "LAB");
            CurrentParties.Add("Hove", "LAB");
            CurrentParties.Add("Huddersfield", "LAB");
            CurrentParties.Add("Huntingdon", "CON");
            CurrentParties.Add("Hyndburn", "LAB");
            CurrentParties.Add("Ilford North", "LAB");
            CurrentParties.Add("Ilford South", "LAB");
            CurrentParties.Add("Inverclyde", "SNP");
            CurrentParties.Add("Inverness, Nairn, Badenoch and Strathspey", "SNP");
            CurrentParties.Add("Ipswich", "CON");
            CurrentParties.Add("Isle Of Wight", "CON");
            CurrentParties.Add("Islington North", "LAB");
            CurrentParties.Add("Islington South and Finsbury", "LAB");
            CurrentParties.Add("Islwyn", "LAB");
            CurrentParties.Add("Jarrow", "LAB");
            CurrentParties.Add("Keighley", "CON");
            CurrentParties.Add("Kensington", "CON");
            CurrentParties.Add("Kettering", "CON");
            CurrentParties.Add("Kilmarnock and Loudoun", "SNP");
            CurrentParties.Add("Kingston and Surbiton", "CON");
            CurrentParties.Add("Kingston upon Hull East", "LAB");
            CurrentParties.Add("Kingston upon Hull North", "LAB");
            CurrentParties.Add("Kingston upon Hull West and Hessle", "LAB");
            CurrentParties.Add("Kingswood", "CON");
            CurrentParties.Add("Kirkcaldy and Cowdenbeath", "SNP");
            CurrentParties.Add("Knowsley", "LAB");
            CurrentParties.Add("Lagan Valley", "DUP");
            CurrentParties.Add("Lanark and Hamilton East", "SNP");
            CurrentParties.Add("Lancaster and Fleetwood", "LAB");
            CurrentParties.Add("Leeds Central", "LAB");
            CurrentParties.Add("Leeds East", "LAB");
            CurrentParties.Add("Leeds North East", "LAB");
            CurrentParties.Add("Leeds North West", "LIB");
            CurrentParties.Add("Leeds West", "LAB");
            CurrentParties.Add("Leicester East", "LAB");
            CurrentParties.Add("Leicester South", "LAB");
            CurrentParties.Add("Leicester West", "LAB");
            CurrentParties.Add("Leigh", "LAB");
            CurrentParties.Add("Lewes", "CON");
            CurrentParties.Add("Lewisham, Deptford", "LAB");
            CurrentParties.Add("Lewisham East", "LAB");
            CurrentParties.Add("Lewisham West and Penge", "LAB");
            CurrentParties.Add("Leyton and Wanstead", "LAB");
            CurrentParties.Add("Lichfield", "CON");
            CurrentParties.Add("Lincoln", "CON");
            CurrentParties.Add("Linlithgow and East Falkirk", "SNP");
            CurrentParties.Add("Liverpool, Riverside", "LAB");
            CurrentParties.Add("Liverpool, Walton", "LAB");
            CurrentParties.Add("Liverpool, Wavertree", "LAB");
            CurrentParties.Add("Liverpool, West Derby", "LAB");
            CurrentParties.Add("Livingston", "SNP");
            CurrentParties.Add("Llanelli", "LAB");
            CurrentParties.Add("Loughborough", "CON");
            CurrentParties.Add("Louth and Horncastle", "CON");
            CurrentParties.Add("Ludlow", "CON");
            CurrentParties.Add("Luton North", "LAB");
            CurrentParties.Add("Luton South", "LAB");
            CurrentParties.Add("Macclesfield", "CON");
            CurrentParties.Add("Maidenhead", "CON");
            CurrentParties.Add("Maidstone and The Weald", "CON");
            CurrentParties.Add("Makerfield", "LAB");
            CurrentParties.Add("Maldon", "CON");
            CurrentParties.Add("Manchester Central", "LAB");
            CurrentParties.Add("Manchester, Gorton", "LAB");
            CurrentParties.Add("Manchester, Withington", "LAB");
            CurrentParties.Add("Mansfield", "LAB");
            CurrentParties.Add("Meon Valley", "CON");
            CurrentParties.Add("Meriden", "CON");
            CurrentParties.Add("Merthyr Tydfil and Rhymney", "LAB");
            CurrentParties.Add("Mid Bedfordshire", "CON");
            CurrentParties.Add("Mid Derbyshire", "CON");
            CurrentParties.Add("Middlesbrough", "LAB");
            CurrentParties.Add("Middlesbrough South and East Cleveland", "LAB");
            CurrentParties.Add("Mid Dorset and North Poole", "CON");
            CurrentParties.Add("Midlothian", "SNP");
            CurrentParties.Add("Mid Norfolk", "CON");
            CurrentParties.Add("Mid Sussex", "CON");
            CurrentParties.Add("Mid Ulster", "SF");
            CurrentParties.Add("Mid Worcestershire", "CON");
            CurrentParties.Add("Milton Keynes North", "CON");
            CurrentParties.Add("Milton Keynes South", "CON");
            CurrentParties.Add("Mitcham and Morden", "LAB");
            CurrentParties.Add("Mole Valley", "CON");
            CurrentParties.Add("Monmouth", "CON");
            CurrentParties.Add("Montgomeryshire", "CON");
            CurrentParties.Add("Moray", "SNP");
            CurrentParties.Add("Morecambe and Lunesdale", "CON");
            CurrentParties.Add("Morley and Outwood", "CON");
            CurrentParties.Add("Motherwell and Wishaw", "SNP");
            CurrentParties.Add("Na h-Eileanan An Iar", "SNP");
            CurrentParties.Add("Neath", "LAB");
            CurrentParties.Add("Newark", "CON");
            CurrentParties.Add("Newbury", "CON");
            CurrentParties.Add("Newcastle-Under-Lyme", "LAB");
            CurrentParties.Add("Newcastle Upon Tyne Central", "LAB");
            CurrentParties.Add("Newcastle Upon Tyne East", "LAB");
            CurrentParties.Add("Newcastle Upon Tyne North", "LAB");
            CurrentParties.Add("New Forest East", "CON");
            CurrentParties.Add("New Forest West", "CON");
            CurrentParties.Add("Newport East", "LAB");
            CurrentParties.Add("Newport West", "LAB");
            CurrentParties.Add("Newry and Armagh", "SF");
            CurrentParties.Add("Newton Abbot", "CON");
            CurrentParties.Add("Normanton, Pontefract and Castleford", "LAB");
            CurrentParties.Add("Northampton North", "CON");
            CurrentParties.Add("Northampton South", "CON");
            CurrentParties.Add("North Antrim", "DUP");
            CurrentParties.Add("North Ayrshire and Arran", "SNP");
            CurrentParties.Add("North Cornwall", "CON");
            CurrentParties.Add("North Devon", "CON");
            CurrentParties.Add("North Dorset", "CON");
            CurrentParties.Add("North Down", "IND");
            CurrentParties.Add("North Durham", "LAB");
            CurrentParties.Add("North East Bedfordshire", "CON");
            CurrentParties.Add("North East Cambridgeshire", "CON");
            CurrentParties.Add("North East Derbyshire", "LAB");
            CurrentParties.Add("North East Fife", "SNP");
            CurrentParties.Add("North East Hampshire", "CON");
            CurrentParties.Add("North East Hertfordshire", "CON");
            CurrentParties.Add("North East Somerset", "CON");
            CurrentParties.Add("North Herefordshire", "CON");
            CurrentParties.Add("North Norfolk", "LIB");
            CurrentParties.Add("North Shropshire", "CON");
            CurrentParties.Add("North Somerset", "CON");
            CurrentParties.Add("North Swindon", "CON");
            CurrentParties.Add("North Thanet", "CON");
            CurrentParties.Add("North Tyneside", "LAB");
            CurrentParties.Add("North Warwickshire", "CON");
            CurrentParties.Add("North West Cambridgeshire", "CON");
            CurrentParties.Add("North West Durham", "LAB");
            CurrentParties.Add("North West Hampshire", "CON");
            CurrentParties.Add("North West Leicestershire", "CON");
            CurrentParties.Add("North West Norfolk", "CON");
            CurrentParties.Add("North Wiltshire", "CON");
            CurrentParties.Add("Norwich North", "CON");
            CurrentParties.Add("Norwich South", "LAB");
            CurrentParties.Add("Nottingham East", "LAB");
            CurrentParties.Add("Nottingham North", "LAB");
            CurrentParties.Add("Nottingham South", "LAB");
            CurrentParties.Add("Nuneaton", "CON");
            CurrentParties.Add("Ochil and South Perthshire", "SNP");
            CurrentParties.Add("Ogmore", "LAB");
            CurrentParties.Add("Old Bexley and Sidcup", "CON");
            CurrentParties.Add("Oldham East and Saddleworth", "LAB");
            CurrentParties.Add("Oldham West and Royton", "LAB");
            CurrentParties.Add("Orkney and Shetland", "LIB");
            CurrentParties.Add("Orpington", "CON");
            CurrentParties.Add("Oxford East", "LAB");
            CurrentParties.Add("Oxford West and Abingdon", "CON");
            CurrentParties.Add("Paisley and Renfrewshire North", "SNP");
            CurrentParties.Add("Paisley and Renfrewshire South", "SNP");
            CurrentParties.Add("Pendle", "CON");
            CurrentParties.Add("Penistone and Stocksbridge", "LAB");
            CurrentParties.Add("Penrith and The Border", "CON");
            CurrentParties.Add("Perth and North Perthshire", "SNP");
            CurrentParties.Add("Peterborough", "CON");
            CurrentParties.Add("Plymouth, Moor View", "CON");
            CurrentParties.Add("Plymouth, Sutton and Devonport", "CON");
            CurrentParties.Add("Pontypridd", "LAB");
            CurrentParties.Add("Poole", "CON");
            CurrentParties.Add("Poplar and Limehouse", "LAB");
            CurrentParties.Add("Portsmouth North", "CON");
            CurrentParties.Add("Portsmouth South", "CON");
            CurrentParties.Add("Preseli Pembrokeshire", "CON");
            CurrentParties.Add("Preston", "LAB");
            CurrentParties.Add("Pudsey", "CON");
            CurrentParties.Add("Putney", "CON");
            CurrentParties.Add("Rayleigh and Wickford", "CON");
            CurrentParties.Add("Reading East", "CON");
            CurrentParties.Add("Reading West", "CON");
            CurrentParties.Add("Redcar", "LAB");
            CurrentParties.Add("Redditch", "CON");
            CurrentParties.Add("Reigate", "CON");
            CurrentParties.Add("Rhondda", "LAB");
            CurrentParties.Add("Ribble Valley", "CON");
            CurrentParties.Add("Richmond Park", "LIB");
            CurrentParties.Add("Richmond (Yorks)", "CON");
            CurrentParties.Add("Rochdale", "LAB");
            CurrentParties.Add("Rochester and Strood", "CON");
            CurrentParties.Add("Rochford and Southend East", "CON");
            CurrentParties.Add("Romford", "CON");
            CurrentParties.Add("Romsey and Southampton North", "CON");
            CurrentParties.Add("Rossendale and Darwen", "CON");
            CurrentParties.Add("Ross, Skye and Lochaber", "SNP");
            CurrentParties.Add("Rotherham", "LAB");
            CurrentParties.Add("Rother Valley", "LAB");
            CurrentParties.Add("Rugby", "CON");
            CurrentParties.Add("Ruislip, Northwood and Pinner", "CON");
            CurrentParties.Add("Runnymede and Weybridge", "CON");
            CurrentParties.Add("Rushcliffe", "CON");
            CurrentParties.Add("Rutherglen and Hamilton West", "SNP");
            CurrentParties.Add("Rutland and Melton", "CON");
            CurrentParties.Add("Saffron Walden", "CON");
            CurrentParties.Add("Salford and Eccles", "LAB");
            CurrentParties.Add("Salisbury", "CON");
            CurrentParties.Add("Scarborough and Whitby", "CON");
            CurrentParties.Add("Scunthorpe", "LAB");
            CurrentParties.Add("Sedgefield", "LAB");
            CurrentParties.Add("Sefton Central", "LAB");
            CurrentParties.Add("Selby and Ainsty", "CON");
            CurrentParties.Add("Sevenoaks", "CON");
            CurrentParties.Add("Sheffield, Brightside and Hillsborough", "LAB");
            CurrentParties.Add("Sheffield Central", "LAB");
            CurrentParties.Add("Sheffield, Hallam", "LIB");
            CurrentParties.Add("Sheffield, Heeley", "LAB");
            CurrentParties.Add("Sheffield South East", "LAB");
            CurrentParties.Add("Sherwood", "CON");
            CurrentParties.Add("Shipley", "CON");
            CurrentParties.Add("Shrewsbury and Atcham", "CON");
            CurrentParties.Add("Sittingbourne and Sheppey", "CON");
            CurrentParties.Add("Skipton and Ripon", "CON");
            CurrentParties.Add("Sleaford and North Hykeham", "CON");
            CurrentParties.Add("Slough", "LAB");
            CurrentParties.Add("Solihull", "CON");
            CurrentParties.Add("Somerton and Frome", "CON");
            CurrentParties.Add("Southampton, Itchen", "CON");
            CurrentParties.Add("Southampton, Test", "LAB");
            CurrentParties.Add("South Antrim", "UUP");
            CurrentParties.Add("South Basildon and East Thurrock", "CON");
            CurrentParties.Add("South Cambridgeshire", "CON");
            CurrentParties.Add("South Derbyshire", "CON");
            CurrentParties.Add("South Dorset", "CON");
            CurrentParties.Add("South Down", "SDLP");
            CurrentParties.Add("South East Cambridgeshire", "CON");
            CurrentParties.Add("South East Cornwall", "CON");
            CurrentParties.Add("Southend West", "CON");
            CurrentParties.Add("South Holland and The Deepings", "CON");
            CurrentParties.Add("South Leicestershire", "CON");
            CurrentParties.Add("South Norfolk", "CON");
            CurrentParties.Add("South Northamptonshire", "CON");
            CurrentParties.Add("Southport", "LIB");
            CurrentParties.Add("South Ribble", "CON");
            CurrentParties.Add("South Shields", "LAB");
            CurrentParties.Add("South Staffordshire", "CON");
            CurrentParties.Add("South Suffolk", "CON");
            CurrentParties.Add("South Swindon", "CON");
            CurrentParties.Add("South Thanet", "CON");
            CurrentParties.Add("South West Bedfordshire", "CON");
            CurrentParties.Add("South West Devon", "CON");
            CurrentParties.Add("South West Hertfordshire", "CON");
            CurrentParties.Add("South West Norfolk", "CON");
            CurrentParties.Add("South West Surrey", "CON");
            CurrentParties.Add("South West Wiltshire", "CON");
            CurrentParties.Add("Spelthorne", "CON");
            CurrentParties.Add("Stafford", "CON");
            CurrentParties.Add("Staffordshire Moorlands", "CON");
            CurrentParties.Add("St Albans", "CON");
            CurrentParties.Add("Stalybridge and Hyde", "LAB");
            CurrentParties.Add("St Austell and Newquay", "CON");
            CurrentParties.Add("Stevenage", "CON");
            CurrentParties.Add("St Helens North", "LAB");
            CurrentParties.Add("St Helens South and Whiston", "LAB");
            CurrentParties.Add("Stirling", "SNP");
            CurrentParties.Add("St Ives", "CON");
            CurrentParties.Add("Stockport", "LAB");
            CurrentParties.Add("Stockton North", "LAB");
            CurrentParties.Add("Stockton South", "CON");
            CurrentParties.Add("Stoke-On-Trent Central", "LAB");
            CurrentParties.Add("Stoke-On-Trent North", "LAB");
            CurrentParties.Add("Stoke-On-Trent South", "LAB");
            CurrentParties.Add("Stone", "CON");
            CurrentParties.Add("Stourbridge", "CON");
            CurrentParties.Add("Strangford", "DUP");
            CurrentParties.Add("Stratford-On-Avon", "CON");
            CurrentParties.Add("Streatham", "LAB");
            CurrentParties.Add("Stretford and Urmston", "LAB");
            CurrentParties.Add("Stroud", "CON");
            CurrentParties.Add("Suffolk Coastal", "CON");
            CurrentParties.Add("Sunderland Central", "LAB");
            CurrentParties.Add("Surrey Heath", "CON");
            CurrentParties.Add("Sutton and Cheam", "CON");
            CurrentParties.Add("Sutton Coldfield", "CON");
            CurrentParties.Add("Swansea East", "LAB");
            CurrentParties.Add("Swansea West", "LAB");
            CurrentParties.Add("Tamworth", "CON");
            CurrentParties.Add("Tatton", "CON");
            CurrentParties.Add("Taunton Deane", "CON");
            CurrentParties.Add("Telford", "CON");
            CurrentParties.Add("Tewkesbury", "CON");
            CurrentParties.Add("The Cotswolds", "CON");
            CurrentParties.Add("The Wrekin", "CON");
            CurrentParties.Add("Thirsk and Malton", "CON");
            CurrentParties.Add("Thornbury and Yate", "CON");
            CurrentParties.Add("Thurrock", "CON");
            CurrentParties.Add("Tiverton and Honiton", "CON");
            CurrentParties.Add("Tonbridge and Malling", "CON");
            CurrentParties.Add("Tooting", "LAB");
            CurrentParties.Add("Torbay", "CON");
            CurrentParties.Add("Torfaen", "LAB");
            CurrentParties.Add("Torridge and West Devon", "CON");
            CurrentParties.Add("Totnes", "CON");
            CurrentParties.Add("Tottenham", "LAB");
            CurrentParties.Add("Truro and Falmouth", "CON");
            CurrentParties.Add("Tunbridge Wells", "CON");
            CurrentParties.Add("Twickenham", "CON");
            CurrentParties.Add("Tynemouth", "LAB");
            CurrentParties.Add("Upper Bann", "DUP");
            CurrentParties.Add("Uxbridge and South Ruislip", "CON");
            CurrentParties.Add("Vale Of Clwyd", "CON");
            CurrentParties.Add("Vale Of Glamorgan", "CON");
            CurrentParties.Add("Vauxhall", "LAB");
            CurrentParties.Add("Wakefield", "LAB");
            CurrentParties.Add("Wallasey", "LAB");
            CurrentParties.Add("Walsall North", "LAB");
            CurrentParties.Add("Walsall South", "LAB");
            CurrentParties.Add("Walthamstow", "LAB");
            CurrentParties.Add("Wansbeck", "LAB");
            CurrentParties.Add("Wantage", "CON");
            CurrentParties.Add("Warley", "LAB");
            CurrentParties.Add("Warrington North", "LAB");
            CurrentParties.Add("Warrington South", "CON");
            CurrentParties.Add("Warwick and Leamington", "CON");
            CurrentParties.Add("Washington and Sunderland West", "LAB");
            CurrentParties.Add("Watford", "CON");
            CurrentParties.Add("Waveney", "CON");
            CurrentParties.Add("Wealden", "CON");
            CurrentParties.Add("Weaver Vale", "CON");
            CurrentParties.Add("Wellingborough", "CON");
            CurrentParties.Add("Wells", "CON");
            CurrentParties.Add("Welwyn Hatfield", "CON");
            CurrentParties.Add("Wentworth and Dearne", "LAB");
            CurrentParties.Add("West Aberdeenshire and Kincardine", "SNP");
            CurrentParties.Add("West Bromwich East", "LAB");
            CurrentParties.Add("West Bromwich West", "LAB");
            CurrentParties.Add("West Dorset", "CON");
            CurrentParties.Add("West Dunbartonshire", "SNP");
            CurrentParties.Add("West Ham", "LAB");
            CurrentParties.Add("West Lancashire", "LAB");
            CurrentParties.Add("Westminster North", "LAB");
            CurrentParties.Add("Westmorland and Lonsdale", "LIB");
            CurrentParties.Add("Weston-Super-Mare", "CON");
            CurrentParties.Add("West Suffolk", "CON");
            CurrentParties.Add("West Tyrone", "SF");
            CurrentParties.Add("West Worcestershire", "CON");
            CurrentParties.Add("Wigan", "LAB");
            CurrentParties.Add("Wimbledon", "CON");
            CurrentParties.Add("Winchester", "CON");
            CurrentParties.Add("Windsor", "CON");
            CurrentParties.Add("Wirral South", "LAB");
            CurrentParties.Add("Wirral West", "LAB");
            CurrentParties.Add("Witham", "CON");
            CurrentParties.Add("Witney", "CON");
            CurrentParties.Add("Woking", "CON");
            CurrentParties.Add("Wokingham", "CON");
            CurrentParties.Add("Wolverhampton North East", "LAB");
            CurrentParties.Add("Wolverhampton South East", "LAB");
            CurrentParties.Add("Wolverhampton South West", "LAB");
            CurrentParties.Add("Worcester", "CON");
            CurrentParties.Add("Workington", "LAB");
            CurrentParties.Add("Worsley and Eccles South", "LAB");
            CurrentParties.Add("Worthing West", "CON");
            CurrentParties.Add("Wrexham", "LAB");
            CurrentParties.Add("Wycombe", "CON");
            CurrentParties.Add("Wyre and Preston North", "CON");
            CurrentParties.Add("Wyre Forest", "CON");
            CurrentParties.Add("Wythenshawe and Sale East", "LAB");
            CurrentParties.Add("Yeovil", "CON");
            CurrentParties.Add("Ynys Mon", "LAB");
            CurrentParties.Add("York Central", "LAB");
            CurrentParties.Add("York Outer", "CON");
            CurrentParties.Add("Kenilworth and Southam", "CON");
            CurrentParties.Add("Buckingham", "SPK");


        }

        public MainWindow()
        {
            InitializeComponent();
            render = new RenderWindow();

            //here we fill the colors dict so we can se them later
            PartyColors.Add("CON", Color.FromRgb(0, 106, 166));
            PartyColors.Add("LAB", Color.FromRgb(168, 0, 0));
            PartyColors.Add("LIB", Color.FromRgb(230, 140, 20));
            PartyColors.Add("UKIP", Color.FromRgb(183, 0, 157));
            PartyColors.Add("SNP", Color.FromRgb(216,187,0));
            PartyColors.Add("OTH", Color.FromRgb(100,100,100));
            FillCurrentData();
        }

        private Color GetPartyColor(string Party)
        {
            try
            {
                return PartyColors[Party];
            }
            catch
            {
                return PartyColors["OTH"];
            }
        }
        private void RenderToggle_Click(object sender, RoutedEventArgs e)
        {
            if (RenderToggle.IsChecked.Value)
            {
                render.Show();
            }
            else
            {
                render.Hide();
            }
        }

        private void Render_NormalButton_Click(object sender, RoutedEventArgs e)
        {
            render.WindowState = WindowState.Normal;
        }

        private void Render_MaximiseButton_Click(object sender, RoutedEventArgs e)
        {
            render.WindowState = WindowState.Maximized;
        }





        #region "Seatometers"
        private void ShowSpeedoButton_Click(object sender, RoutedEventArgs e)
        {
            render.Anim_ShowSpeedo();
        }

        private void HideSpeedoButton_Click(object sender, RoutedEventArgs e)
        {
            render.Anim_HideSpeedo();
        }

        //CON
        private void ConRem_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(render.ConservativeSpeedo.GetSeats() - 1);
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        private void ConAdd_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(render.ConservativeSpeedo.GetSeats() + 1);
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        private void ConSet_Click(object sender, RoutedEventArgs e)
        {
            render.ConservativeSpeedo.SetSeats(Convert.ToInt32(ConSeats.Text));
            ConSeats.Text = render.ConservativeSpeedo.GetSeats().ToString();
        }
        //LAB
        private void LabRem_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(render.LabourSpeedo.GetSeats() - 1);
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        private void LabAdd_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(render.LabourSpeedo.GetSeats() + 1);
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        private void LabSet_Click(object sender, RoutedEventArgs e)
        {
            render.LabourSpeedo.SetSeats(Convert.ToInt32(LabSeats.Text));
            LabSeats.Text = render.LabourSpeedo.GetSeats().ToString();
        }
        //LBDM
        private void LbdRem_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(render.LibDemSpeedo.GetSeats() - 1);
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        private void LbdAdd_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(render.LibDemSpeedo.GetSeats() + 1);
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        private void LbdSet_Click(object sender, RoutedEventArgs e)
        {
            render.LibDemSpeedo.SetSeats(Convert.ToInt32(LibSeats.Text));
            LibSeats.Text = render.LibDemSpeedo.GetSeats().ToString();
        }
        //Ukip
        private void UkipRem_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(render.UkipSpeedo.GetSeats() - 1);
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        private void UkipAdd_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(render.UkipSpeedo.GetSeats() + 1);
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        private void UkipSet_Click(object sender, RoutedEventArgs e)
        {
            render.UkipSpeedo.SetSeats(Convert.ToInt32(UkipSeats.Text));
            UkipSeats.Text = render.UkipSpeedo.GetSeats().ToString();
        }
        //SNP
        private void SnpRem_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(render.SNPSpeedo.GetSeats() - 1);
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        private void SnpAdd_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(render.SNPSpeedo.GetSeats() + 1);
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        private void SnpSet_Click(object sender, RoutedEventArgs e)
        {
            render.SNPSpeedo.SetSeats(Convert.ToInt32(SNPSeats.Text));
            SNPSeats.Text = render.SNPSpeedo.GetSeats().ToString();
        }
        //Other
        private void OthRem_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(render.MiscSpeedo.GetSeats() - 1);
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }
        private void OthAdd_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(render.MiscSpeedo.GetSeats() + 1);
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }
        private void OthSet_Click(object sender, RoutedEventArgs e)
        {
            render.MiscSpeedo.SetSeats(Convert.ToInt32(OthSeats.Text));
            OthSeats.Text = render.MiscSpeedo.GetSeats().ToString();
        }



        #endregion

        private void Constituencies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string constituency = ((Label)Constituencies.SelectedValue).Content.ToString();
            CurrentDeclaration.Constituency = constituency;
            CurrentDeclaration.OldPartyColor = GetPartyColor(CurrentParties[constituency]);
            Parties.Text = CurrentParties[constituency];
        }
        

        private void ConfirmWinner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string party = (Parties.Text.ToUpper()).ToString();
                if (party == CurrentParties[CurrentDeclaration.Constituency])
                {
                    CurrentDeclaration.Declare(party + " HOLD", GetPartyColor(party));
                }
                else
                {
                    CurrentDeclaration.Declare(party + " GAIN", GetPartyColor(party));
                }
                Constituencies.IsEnabled = false;
                ConfirmWinner.IsEnabled = false;
            }
            catch { }
        }
        internal DeclarationControl CurrentDeclaration = null;
        private void NewDeclarationButton_Click(object sender, RoutedEventArgs e)
        {
            Parties.IsEnabled = true;
            Constituencies.IsEnabled = true;
            ConfirmWinner.IsEnabled = true;
            //Now to actaully do the new control
            var control = new DeclarationControl();
            control.MouseDoubleClick += RemoveDeclaration;
            control.Width = 500;
            CurrentDeclaration = control;

            render.Declarations.Children.Insert(0,control);
            Constituencies.Focus();
        }
        private void RemoveDeclaration(object Sender, EventArgs e)
        {
            render.Declarations.Children.Remove(Sender as DeclarationControl);
        }
    }
}
