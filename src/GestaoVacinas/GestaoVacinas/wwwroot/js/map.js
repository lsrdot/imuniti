// import { MarkerClusterer } from "@googlemaps/markerclusterer";    

var latitude = null;
var longitude = null;

if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(function (position) {
        latitude = position.coords.latitude;
        longitude = position.coords.longitude;

        initMap();
    });
}

function initMap() {
    if (latitude !== null && longitude !== null) {
        var userLocation = {lat: latitude, lng: longitude};
        console.log("Latitude: " + userLocation.lat);
        console.log("Longitude: " + userLocation.lng);

        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 15,
            center: userLocation
        });


        var userMarker = new google.maps.Marker({
            position: userLocation,
            map: map,
            title: "Você está aqui",
            icon: "" // Ícone vermelho padrão
        });

        // ##################### Centros de Saúde da Regional Barreiro #################################

        var ubs1 = {lat: -19.99538139910171, lng: -44.0048212134914};
        var marker1 = new google.maps.Marker({
            position: ubs1,
            map: map,
            title: "Centro de Saúde Barreiro de Cima",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });


        var ubs2 = {lat: -19.986114059892497, lng: -43.988858799999996};
        var marker2 = new google.maps.Marker({
            position: ubs2,
            map: map,
            title: "Centro de Saúde Bonsucesso",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs3 = {lat: -19.976019561281976, lng: -44.02257561850931};
        var marker3 = new google.maps.Marker({
            position: ubs3,
            map: map,
            title: "Centro de Saúde Carlos Renato Dias",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs4 = {lat: -19.9908635872542, lng: -44.01577773068961};
        var marker4 = new google.maps.Marker({
            position: ubs4,
            map: map,
            title: "Centro de Saúde Diamante / Teixeira Dias",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs5 = {lat: -19.96286609908091, lng: -44.000671253965606};
        var marker5 = new google.maps.Marker({
            position: ubs5,
            map: map,
            title: "Centro de Saúde Dr. José Domingos",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs6 = {lat: -19.996713276665112, lng: -44.0115510846552};
        var marker6 = new google.maps.Marker({
            position: ubs6,
            map: map,
            title: "Centro de Saúde Eduardo Mauro de Araújo - Miramar",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs7 = {lat: -19.9847879586489, lng: -44.03540649532567};
        var marker7 = new google.maps.Marker({
            position: ubs7,
            map: map,
            title: "Centro de Saúde Francisco Gomes Barbosa - Tirol",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs8 = {lat: -20.01869574771863, lng: -44.0317167460344};
        var marker8 = new google.maps.Marker({
            position: ubs8,
            map: map,
            title: "Centro de Saúde Independência",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });


        var ubs9 = {lat: -19.995239227858214, lng: -44.0487899460344};
        var marker9 = new google.maps.Marker({
            position: ubs9,
            map: map,
            title: "Centro de Saúde Itaipu/Jatobá",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs10 = {lat: -19.98791677871133, lng: -44.04636966144025};
        var marker10 = new google.maps.Marker({
            position: ubs10,
            map: map,
            title: "Centro de Saúde Lisandra Angélica David Justino - Túnel de Ibirité",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs11 = {lat: -19.97914046153702, lng: -44.04660182944759};
        var marker11 = new google.maps.Marker({
            position: ubs11,
            map: map,
            title: "Centro de Saúde Maria Madalena Teodoro - Lindéia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs12 = {lat: -20.013589437536535, lng: -44.03081984109025};
        var marker12 = new google.maps.Marker({
            position: ubs12,
            map: map,
            title: "Centro de Saúde Mangueiras",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs13 = {lat: -19.981205397252182, lng: -43.99924397729833};
        var marker13 = new google.maps.Marker({
            position: ubs13,
            map: map,
            title: "Centro de Saúde Milionários",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs14 = {lat: -19.99961402045817, lng: -43.96706485767241};
        var marker14 = new google.maps.Marker({
            position: ubs14,
            map: map,
            title: "Centro de Saúde Pilar - Olhos D'Agua",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs15 = {lat: -19.98255280414954, lng: -44.0547778189476};
        var marker15 = new google.maps.Marker({
            position: ubs15,
            map: map,
            title: "Centro de Saúde Regina",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs16 = {lat: -19.999601811409768, lng: -44.03281761746444};
        var marker16 = new google.maps.Marker({
            position: ubs16,
            map: map,
            title: "Centro de Saúde Santa Cecília",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs17 = {lat: -20.009403079508584, lng: -44.007426499994686};
        var marker17 = new google.maps.Marker({
            position: ubs17,
            map: map,
            title: "Centro de Saúde Urucuia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs18 = {lat: -20.010283115963954, lng: -44.03625666441447};
        var marker18 = new google.maps.Marker({
            position: ubs18,
            map: map,
            title: "Centro de Saúde Vale do Jatobá",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs19 = {lat: -19.997734577071277, lng: -43.99258693558189};
        var marker19 = new google.maps.Marker({
            position: ubs19,
            map: map,
            title: "Centro de Saúde Vila CEMIG",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs20 = {lat: -20.00076979557301, lng: -44.026135199993085};
        var marker20 = new google.maps.Marker({
            position: ubs20,
            map: map,
            title: "Centro de Saúde Vila Pinho",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ##################### Centros de Saúde da Regional Centro-Sul #################################

        var ubs21 = {lat: -19.936197002812687, lng: -43.911186052134575};
        var marker21 = new google.maps.Marker({
            position: ubs21,
            map: map,
            title: "Centro de Saúde Cafezal ",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs22 = {lat: -19.928705787204436, lng: -43.92351942943919};
        var marker22 = new google.maps.Marker({
            position: ubs22,
            map: map,
            title: "Centro de Saúde Carlos Chagas",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs23 = {lat: -19.952639154952497, lng: -43.954571057685506};
        var marker23 = new google.maps.Marker({
            position: ubs23,
            map: map,
            title: "Centro de Saúde Conjunto Santa Maria",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });


        var ubs24 = {lat: -19.943076238391754, lng: -43.941991817787034};
        var marker24 = new google.maps.Marker({
            position: ubs24,
            map: map,
            title: "Centro de Saúde Menino Jesus",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs25 = {lat: -19.930568711505327, lng: -43.9173369921875};
        var marker25 = new google.maps.Marker({
            position: ubs25,
            map: map,
            title: "Centro de Saúde Nossa Senhora Aparecida",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs26 = {lat: -19.942243955268435, lng: -43.914415628834725};
        var marker26 = new google.maps.Marker({
            position: ubs26,
            map: map,
            title: "Centro de Saúde Nossa Senhora de Fátima",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs27 = {lat: -19.92042300001387, lng: -43.95579250982396};
        var marker27 = new google.maps.Marker({
            position: ubs27,
            map: map,
            title: "Centro de Saúde Oswaldo Cruz",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs28 = {lat: -19.933424669757258, lng: -43.91534239006988};
        var marker28 = new google.maps.Marker({
            position: ubs28,
            map: map,
            title: "Centro de Saúde Padre Tarcísio",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs29 = {lat: -19.93473866447394, lng: -43.90231113558154};
        var marker29 = new google.maps.Marker({
            position: ubs29,
            map: map,
            title: "Centro de Saúde São Miguel Arcanjo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs30 = {lat: -19.950547542476862, lng: -43.946549735586046};
        var marker30 = new google.maps.Marker({
            position: ubs30,
            map: map,
            title: "Centro de Saúde Santa Lúcia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs31 = {lat: -19.946478170466825, lng: -43.93880522883942};
        var marker31 = new google.maps.Marker({
            position: ubs31,
            map: map,
            title: "Centro de Saúde Santa Rita de Cássia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs32 = {lat: -19.947818892930822, lng: -43.949947468823076};
        var marker32 = new google.maps.Marker({
            position: ubs32,
            map: map,
            title: "Centro de Saúde Tia Amância",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ##################### Centros de Saúde da Regional Leste #################################

        var ubs33 = {lat: -19.91052367482825, lng: -43.8894515883759};
        var marker33 = new google.maps.Marker({
            position: ubs33,
            map: map,
            title: "Centro de Saúde Alto Vera Cruz",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs34 = {lat: -19.892185566503557, lng: -43.89717902881993};
        var marker34 = new google.maps.Marker({
            position: ubs34,
            map: map,
            title: "Centro de Saúde Boa Vista",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs35 = {lat: -19.911127188887416, lng: -43.88761415852155};
        var marker35 = new google.maps.Marker({
            position: ubs35,
            map: map,
            title: "Centro de Saúde Granja de Freitas",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs36 = {lat: -19.913026356312315, lng: -43.92048447976485};
        var marker36 = new google.maps.Marker({
            position: ubs36,
            map: map,
            title: "Centro de Saúde Horto",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs37 = {lat: -19.900963546439982, lng: -43.886699641101714};
        var marker37 = new google.maps.Marker({
            position: ubs37,
            map: map,
            title: "Centro de Saúde Mariano de Abreu",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs38 = {lat: -19.905603020692435, lng: -43.915526761562155};
        var marker38 = new google.maps.Marker({
            position: ubs38,
            map: map,
            title: "Centro de Saúde Marco Antônio Menezes",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs39 = {lat: -19.9170718217734, lng: -43.87570737238457};
        var marker39 = new google.maps.Marker({
            position: ubs39,
            map: map,
            title: "Centro de Saúde Novo Horizonte",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs40 = {lat: -19.92440931289334, lng: -43.90814832943635};
        var marker40 = new google.maps.Marker({
            position: ubs40,
            map: map,
            title: "Centro de Saúde Paraíso",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs41 = {lat: -19.912482275597622, lng: -43.90437473793611};
        var marker41 = new google.maps.Marker({
            position: ubs41,
            map: map,
            title: "Centro de Saúde Pompéia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs42 = {lat: -19.887764405834513, lng: -43.906165940470665};
        var marker42 = new google.maps.Marker({
            position: ubs42,
            map: map,
            title: "Centro de Saúde Santa Inês",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs43 = {lat: -19.896541136845624, lng: -43.90209867055982};
        var marker43 = new google.maps.Marker({
            position: ubs43,
            map: map,
            title: "Centro de Saude São Geraldo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs44 = {lat: -19.887659657408353, lng: -43.898471678436685};
        var marker44 = new google.maps.Marker({
            position: ubs44,
            map: map,
            title: "Centro de Saúde São José Operário",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs45 = {lat: -19.918249784088715, lng: -43.88784729916645};
        var marker45 = new google.maps.Marker({
            position: ubs45,
            map: map,
            title: "Centro de Saúde Taquaril",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs46 = {lat: -19.91184968122618, lng: -43.89647714588412};
        var marker46 = new google.maps.Marker({
            position: ubs46,
            map: map,
            title: "Centro de Saúde Vera Cruz",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ##################### Centros de Saúde da Regional Nordeste #################################

        var ubs47 = {lat: -19.89522019977205, lng: -43.93756513904122};
        var marker47 = new google.maps.Marker({
            position: ubs47,
            map: map,
            title: "Centro de Saúde Alcides Lins",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs48 = {lat: -19.893454683229763, lng: -43.94494972331312};
        var marker48 = new google.maps.Marker({
            position: ubs48,
            map: map,
            title: "Centro de Saúde Cachoeirinha",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs49 = {lat: -19.830649748892743, lng: -43.86785662465741};
        var marker49 = new google.maps.Marker({
            position: ubs49,
            map: map,
            title: "Centro de Saúde Capitão Eduardo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs50 = {lat: -19.884402679561155, lng: -43.93226898958495};
        var marker50 = new google.maps.Marker({
            position: ubs50,
            map: map,
            title: "Centro de Saúde Cidade Ozanan",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs51 = {lat: -19.8331053705512, lng: -43.88296207242081};
        var marker51 = new google.maps.Marker({
            position: ubs51,
            map: map,
            title: "Centro de Saúde Conjunto Paulo VI",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs52 = {lat: -19.87562627756228, lng: -43.91598659999899};
        var marker52 = new google.maps.Marker({
            position: ubs52,
            map: map,
            title: "Centro de Saúde Dom Joaquim",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs53 = {lat: -19.82571487129083, lng: -43.89875672923576};
        var marker53 = new google.maps.Marker({
            position: ubs53,
            map: map,
            title: "Centro de Saúde Efigênia Murta de Figueiredo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs54 = {lat: -19.85686238410398, lng: -43.91420257393027};
        var marker54 = new google.maps.Marker({
            position: ubs54,
            map: map,
            title: "Centro de Saúde Fábio Correa Lima (antigo São Gabriel)",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs55 = {lat: -19.874107751608154, lng: -43.94595679531699};
        var marker55 = new google.maps.Marker({
            position: ubs55,
            map: map,
            title: "Centro de Saúde Gentil Gomes",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs56 = {lat: -19.86354081788423, lng: -43.897737593990826};
        var marker56 = new google.maps.Marker({
            position: ubs56,
            map: map,
            title: "Centro de Saúde Goiânia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs57 = {lat: -19.843777314271637, lng: -43.87908205500121};
        var marker57 = new google.maps.Marker({
            position: ubs57,
            map: map,
            title: "Centro de Saúde João Vital",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs58 = {lat: -19.884113972630978, lng: -43.920948962700464};
        var marker58 = new google.maps.Marker({
            position: ubs58,
            map: map,
            title: "Centro de Saúde Leopoldo Chrisóstomo de Castro",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs59 = {lat: -19.859799887359497, lng: -43.88240364909261};
        var marker59 = new google.maps.Marker({
            position: ubs59,
            map: map,
            title: "Centro de Saúde Marcelo Pontel Gomes",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs60 = {lat: -19.86729997331069, lng: -43.90492652848418};
        var marker60 = new google.maps.Marker({
            position: ubs60,
            map: map,
            title: "Centro de Saúde Maria Goretti/Ipê",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs61 = {lat: -19.841814702991318, lng: -43.88902860122438};
        var marker61 = new google.maps.Marker({
            position: ubs61,
            map: map,
            title: "Centro de Saúde Marivanda Baleeiro",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs62 = {lat: -19.85200648679087, lng: -43.893606202448396};
        var marker62 = new google.maps.Marker({
            position: ubs62,
            map: map,
            title: "Centro de Saúde Nazaré",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs63 = {lat: -19.850795992121366, lng: -43.90548704662633};
        var marker63 = new google.maps.Marker({
            position: ubs63,
            map: map,
            title: "Centro de Saúde Olavo Albino Correia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs64 = {lat: -19.87223227177941, lng: -43.938532886091345};
        var marker64 = new google.maps.Marker({
            position: ubs64,
            map: map,
            title: "Centro de Saúde Padre Fernando de Melo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs65 = {lat: -19.837773768571534, lng: -43.90112576605728};
        var marker65 = new google.maps.Marker({
            position: ubs65,
            map: map,
            title: "Centro de Saúde Ribeiro de Abreu",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs66 = {lat: -19.871007891878968, lng: -43.91471295276184};
        var marker66 = new google.maps.Marker({
            position: ubs66,
            map: map,
            title: "Centro de Saúde São Marcos",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs67 = {lat: -19.866714391936238, lng: -43.924312713677494};
        var marker67 = new google.maps.Marker({
            position: ubs67,
            map: map,
            title: "Centro de Saúde São Paulo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs68 = {lat: -19.852687047815824, lng: -43.88554698020706};
        var marker68 = new google.maps.Marker({
            position: ubs68,
            map: map,
            title: "Centro de Saúde Vila Maria",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ##################### Centros de Saúde da Regional Noroeste #################################
        var ubs69 = {lat: -19.89475750148231, lng: -43.955666225055246};
        var marker69 = new google.maps.Marker({
            position: ubs69,
            map: map,
            title: "Centro de Saúde Bom Jesus\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs70 = {lat: -19.923116859028305, lng: -44.010008599636485};
        var marker70 = new google.maps.Marker({
            position: ubs70,
            map: map,
            title: "Centro de Saúde Califórnia\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs71 = {lat: -19.923116547664304, lng: -44.010004968126424};
        var marker71 = new google.maps.Marker({
            position: ubs71,
            map: map,
            title: "Centro de Saúde Califórnia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs72 = {lat: -19.91474141019264, lng: -43.96347043711148};
        var marker72 = new google.maps.Marker({
            position: ubs72,
            map: map,
            title: "Centro de Saúde Carlos Prates",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs73 = {lat: -19.897743952067966, lng: -44.02226280469639};
        var marker73 = new google.maps.Marker({
            position: ubs73,
            map: map,
            title: "Centro de Saúde Coqueiros",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs74 = {lat: -19.912148980271255, lng: -43.99963106747362};
        var marker74 = new google.maps.Marker({
            position: ubs74,
            map: map,
            title: "Centro de Saúde Dom Bosco\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs75 = {lat: -19.923176825682845, lng: -43.99996908331488};
        var marker75 = new google.maps.Marker({
            position: ubs75,
            map: map,
            title: "Centro de Saúde Dom Cabral\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs76 = {lat: -19.890369538827546, lng: -43.95834904685573};
        var marker76 = new google.maps.Marker({
            position: ubs76,
            map: map,
            title: "Centro de Saúde Ermelinda\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs77 = {lat: -19.901554244048384, lng: -44.01683168220915};
        var marker77 = new google.maps.Marker({
            position: ubs77,
            map: map,
            title: "Centro de Saúde Glória\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs78 = {lat: -19.909757919251156, lng: -44.00901241493675};
        var marker78 = new google.maps.Marker({
            position: ubs78,
            map: map,
            title: "Centro de Saúde Jardim Filadélfia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs79 = {lat: -19.904039295488467, lng: -43.98174270897587};
        var marker79 = new google.maps.Marker({
            position: ubs79,
            map: map,
            title: "Centro de Saúde Jardim Montanhês\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs80 = {lat: -19.92759080649368, lng: -44.00354252033753};
        var marker80 = new google.maps.Marker({
            position: ubs80,
            map: map,
            title: "Centro de Saúde João Pinheiro\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs81 = {lat: -19.915395179290762, lng: -43.98922002794069};
        var marker81 = new google.maps.Marker({
            position: ubs81,
            map: map,
            title: "Centro de Saúde Padre Eustáquio\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs82 = {lat: -19.90185023693366, lng: -43.95054458536953};
        var marker82 = new google.maps.Marker({
            position: ubs82,
            map: map,
            title: "Centro de Saúde Pedreira Prado Lopes\n",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs83 = {lat: -19.908432390074566, lng: -44.02086450203925};
        var marker83 = new google.maps.Marker({
            position: ubs83,
            map: map,
            title: "Centro de Saúde Pindorama - Elza Martins",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs84 = {lat: -19.904992706825713, lng: -43.95652607054466};
        var marker84 = new google.maps.Marker({
            position: ubs84,
            map: map,
            title: "Centro de Saúde Santos Anjos",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs85 = {lat: -19.90853347403698, lng: -43.944282203250914};
        var marker85 = new google.maps.Marker({
            position: ubs85,
            map: map,
            title: "Centro de Saúde São Cristóvão",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ######################################################### CENTROS DE SAÚDE DA REGIONAL NORTE  #########################################################
        var ubs86 = { lat:-19.845961111827002,  lng: -43.92080300789881}; 
        var marker86 = new google.maps.Marker({
            position: ubs86,
            map: map,
            title: "Centro de Saúde Aarão Reis",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs87 = { lat:-19.82994071579825,   lng: -43.949277569395136};
        var marker87 = new google.maps.Marker({
            position: ubs87,
            map: map,
            title: "Centro de Saúde Campo Alegre",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs88 = { lat:-19.81205600160813,   lng:-43.9317943491876 };
        var marker88 = new google.maps.Marker({
            position: ubs88,
            map: map,
            title: "Centro de Saúde Etelvina Carneiro",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs89 = { lat:-19.839477210922333,  lng:  -43.93343260585651};
        var marker89 = new google.maps.Marker({
            position: ubs89,
            map: map,
            title: "Centro de Saúde Floramar",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs90 = { lat:-19.842582503790517,   lng: -43.92422021286648};
        var marker90 = new google.maps.Marker({
            position: ubs90,
            map: map,
            title: "Centro de Saúde Guarani",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs91 = { lat: -19.84403634823109, lng: -43.942035775902525}; 
        var marker91 = new google.maps.Marker({
            position: ubs91,
            map: map,
            title: "Centro de Saúde Heliópolis",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs92 = { lat: -19.828468982337416, lng: -43.9328153880572}; 
        var marker92 = new google.maps.Marker({
            position: ubs92,
            map: map,
            title: "Centro de Saúde Jardim Guanabara",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs93 = { lat: -19.801819305619354,  lng: -43.93658885694319};
        var marker93 = new google.maps.Marker({
            position: ubs93,
            map: map,
            title: "Centro de Saúde Jaqueline",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs94 = { lat: -19.805251940483483, lng: -43.94385839313802}; 
        var marker94 = new google.maps.Marker({
            position: ubs94,
            map: map,
            title: "Centro de Saúde Jaqueline II",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

         
        var ubs95 = { lat:-19.829831954466044,  lng:-43.92783331204149 };
        var marker95 = new google.maps.Marker({
            position: ubs95,
            map: map,
            title: "Centro de Saúde Jardim Felicidade",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs95 = { lat: -19.82495248510348,  lng: -43.93077218953412}; 
        var marker95 = new google.maps.Marker({
            position: ubs95,
            map: map,
            title: "Centro de Saúde Jardim Felicidade II",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs96 = { lat: -19.834080090759407,  lng:-43.91364355163768 }; 
        var marker96 = new google.maps.Marker({
            position: ubs96,
            map: map,
            title: "Centro de Saúde Lajedo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs97 = { lat:-19.816477186042132,  lng: -43.88443567055173};  
        var marker97 = new google.maps.Marker({
            position: ubs97,
            map: map,
            title: "Centro de Saúde MG20 - Monte Azul",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs98 = { lat:-19.84595344253785,   lng: -43.92080294452016};
        var marker98 = new google.maps.Marker({
            position: ubs98,
            map: map,
            title: "Centro de Saúde Novo Aarão Reis",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs99 = { lat: -19.861334350844167, lng: -43.927869363016974}; 
        var marker99 = new google.maps.Marker({
            position: ubs99,
            map: map,
            title: "Centro de Saúde Primeiro de Maio",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs100 = { lat: -19.853322998306083, lng: -43.929122578264156}; 
        var marker100 = new google.maps.Marker({
            position: ubs100,
            map: map,
            title: "Centro de Saúde Providência",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs101 = { lat:-19.848155466845743,   lng: -43.938430046003106};
        var marker101 = new google.maps.Marker({
            position: ubs101,
            map: map,
            title: "Centro de Saúde São Bernardo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs102 = { lat:-19.845168443641313,  lng: -43.95332694514665}; 
        var marker102 = new google.maps.Marker({
            position: ubs102,
            map: map,
            title: "Centro de Saúde São Tomás",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs103 = { lat: -19.83578313812115, lng: -43.922650066229956}; 
        var marker103 = new google.maps.Marker({
            position: ubs103,
            map: map,
            title: "Centro de Saúde Tupi",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs104 = { lat: -19.80485793562961,  lng: -43.928113476248946}; 
        var marker104 = new google.maps.Marker({
            position: ubs104,
            map: map,
            title: "Centro de Saúde Zilah Spósito",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ######################################################### CENTROS DE SAÚDE DA REGIONAL OESTE  #########################################################
        var ubs105 = { lat: -19.957681496327066, lng: -43.984282483828956}; 
        var marker105 = new google.maps.Marker({
            position: ubs105,
            map: map,
            title: "Centro de Saúde Amílcar Vianna Martins",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs106 = { lat:-19.9643959890031,  lng: -43.99562352451961}; 
        var marker106 = new google.maps.Marker({
            position: ubs106,
            map: map,
            title: "Centro de Saúde Betânia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs107 = { lat:-19.943224777421026,  lng: -43.9967015121303}; 
        var marker107 = new google.maps.Marker({
            position: ubs107,
            map: map,
            title: "Centro de Saúde Cabana",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs108 = { lat:-19.954807193076174,  lng: -43.99789076563478}; 
        var marker108 = new google.maps.Marker({
            position: ubs108,
            map: map,
            title: "Centro de Saúde Cícero Ildefonso",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs109 = { lat: -19.96439776028679, lng: -43.995620889502}; 
        var marker109 = new google.maps.Marker({
            position: ubs109,
            map: map,
            title: "Centro de Saúde Conjunto Betânia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs110 = { lat: -19.96647397856971, lng: -43.97286554784141}; 
        var marker110 = new google.maps.Marker({
            position: ubs110,
            map: map,
            title: "Centro de Saúde Havaí",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs111 = { lat: -19.966470433956143, lng: -43.97286669474064}; 
        var marker111 = new google.maps.Marker({
            position: ubs111,
            map: map,
            title: "Centro de Saúde Havaí",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs112 = { lat:-19.937524761623905,  lng: -44.005738226611236}; 
        var marker112 = new google.maps.Marker({
            position: ubs112,
            map: map,
            title: "Centro de Saúde João XXIII",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs113 = { lat:-19.930485625268595,  lng: -43.97294296569909}; 
        var marker113 = new google.maps.Marker({
            position: ubs113,
            map: map,
            title: "Centro de Saúde Noraldino de Lima",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs114 = { lat:-19.972160639551262,  lng: -43.978305491281596}; 
        var marker114 = new google.maps.Marker({
            position: ubs114,
            map: map,
            title: "Centro de Saúde Palmeiras",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs115 = { lat:-19.944068871326998,  lng: -43.98498603344127}; 
        var marker115 = new google.maps.Marker({
            position: ubs115,
            map: map,
            title: "Centro de Saúde Salgado Filho",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs116 = { lat: -19.93319303622752, lng: -44.0168313150926}; 
        var marker116 = new google.maps.Marker({
            position: ubs116,
            map: map,
            title: "Centro de Saúde Santa Maria",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs117 = { lat:-19.944874719281337,  lng: -43.9648674284812}; 
        var marker117 = new google.maps.Marker({
            position: ubs117,
            map: map,
            title: "Centro de Saúde São Jorge",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs118 = { lat:-19.95083258421577,  lng: -43.97160035288162}; 
        var marker118 = new google.maps.Marker({
            position: ubs118,
            map: map,
            title: "Centro de Saúde Ventosa",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs119 = { lat: -19.94910601437035, lng: -44.0046999007868}; 
        var marker119 = new google.maps.Marker({
            position: ubs119,
            map: map,
            title: "Centro de Saúde Vila Imperial",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs120 = { lat: -19.955930841769465, lng: -43.9653867583237}; 
        var marker120 = new google.maps.Marker({
            position: ubs120,
            map: map,
            title: "Centro de Saúde Vila Leonina",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs121 = { lat:-19.949478118111173,  lng: -43.991642858894004}; 
        var marker121 = new google.maps.Marker({
            position: ubs121,
            map: map,
            title: "Centro de Saúde Vista Alegre",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs122 = { lat:-19.94598730318059,  lng: -44.0052375544952}; 
        var marker122 = new google.maps.Marker({
            position: ubs122,
            map: map,
            title: "Centro de Saúde Waldomiro Lobo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });


        // ######################################################### Centros de Saúde da Regional Pampulha  #########################################################
        var ubs123 = { lat:-19.863970928203038,  lng: -44.002772585536604}; 
        var marker123 = new google.maps.Marker({
            position: ubs123,
            map: map,
            title: "Centro de Saúde Confisco",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs124 = { lat: -19.865074453411324, lng: -43.9828206554989}; 
        var marker124 = new google.maps.Marker({
            position: ubs124,
            map: map,
            title: "Centro de Saúde Dom Orione",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs125 = { lat: -19.86844226850877, lng: -43.98782897699165}; 
        var marker125 = new google.maps.Marker({
            position: ubs125,
            map: map,
            title: "Centro de Saúde Itamarati",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs126 = { lat:-19.89406437249959,  lng: -43.98361374110745}; 
        var marker126 = new google.maps.Marker({
            position: ubs126,
            map: map,
            title: "Centro de Saúde Jardim Alvorada",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs127 = { lat:-19.88528543568717,  lng: -43.98755316238604}; 
        var marker127 = new google.maps.Marker({
            position: ubs127,
            map: map,
            title: "Centro de Saúde Ouro Preto",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs128 = { lat: -19.855788049784454, lng: -43.954649365724705}; 
        var marker128 = new google.maps.Marker({
            position: ubs128,
            map: map,
            title: "Centro de Saúde Padre Joaquim Maia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs129 = { lat: -19.9007327336555, lng: -43.993826415533995}; 
        var marker129 = new google.maps.Marker({
            position: ubs129,
            map: map,
            title: "Centro de Saúde Padre Tiago",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs130 = { lat: -19.83770052827268, lng: -43.9672588147491}; 
        var marker130 = new google.maps.Marker({
            position: ubs130,
            map: map,
            title: "Centro de Saúde Santa Amélia",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs131 = { lat:-19.86662014406427,  lng: -43.94348882287792}; 
        var marker131 = new google.maps.Marker({
            position: ubs131,
            map: map,
            title: "Centro de Saúde Santa Rosa",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs132 = { lat: -19.874784456322814, lng: -44.006767741105946}; 
        var marker132 = new google.maps.Marker({
            position: ubs132,
            map: map,
            title: "Centro de Saúde Santa Terezinha",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs133 = { lat: -19.876780915301936, lng: -43.953309094171495}; 
        var marker133 = new google.maps.Marker({
            position: ubs133,
            map: map,
            title: "Centro de Saúde São Francisco",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs134 = { lat:-19.900417510392824,  lng: -43.998946075111405}; 
        var marker134 = new google.maps.Marker({
            position: ubs134,
            map: map,
            title: "Centro de Saúde São José",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs135 = { lat:-19.884640132625197,  lng: -44.00981763440313}; 
        var marker135 = new google.maps.Marker({
            position: ubs135,
            map: map,
            title: "Centro de Saúde Serrano",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs136 = { lat: -19.833017684550335, lng:-44.00693510651626 }; 
        var marker136 = new google.maps.Marker({
            position: ubs136,
            map: map,
            title: "Centro de Saúde Trevo",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        // ######################################################### Centros de Saúde da Regional Venda Nova  #########################################################
        var ubs137 = { lat:-19.81784599968783,  lng:-43.973894748416384 }; 
        var marker137 = new google.maps.Marker({
            position: ubs137,
            map: map,
            title: "Centro de Saúde Alameda dos Ipês",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs138 = { lat:-19.819764700827676,  lng: -43.96304584913796}; 
        var marker138 = new google.maps.Marker({
            position: ubs138,
            map: map,
            title: "Centro de Saúde Andradas",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs139 = { lat:-19.81970822961703,  lng: -43.998453869021944}; 
        var marker139 = new google.maps.Marker({
            position: ubs139,
            map: map,
            title: "Centro de Saúde Céu Azul",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs140 = { lat:-19.83429174984683,  lng: -43.98608879360255}; 
        var marker140 = new google.maps.Marker({
            position: ubs140,
            map: map,
            title: "Centro de Saúde Copacabana",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs141 = { lat: -19.787994160693515, lng: -43.97588704693135}; 
        var marker141 = new google.maps.Marker({
            position: ubs141,
            map: map,
            title: "Centro de Saúde Jardim dos Comerciários",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs142 = { lat: -19.787991952343116, lng: -43.975880676685684}; 
        var marker142 = new google.maps.Marker({
            position: ubs142,
            map: map,
            title: "Centro de Saúde Jardim dos Comerciários",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs143 = { lat: -19.800416620581593, lng: -43.967070939569155}; 
        var marker143 = new google.maps.Marker({
            position: ubs143,
            map: map,
            title: "Centro de Saúde Jardim Europa",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs144 = { lat: -19.825797259631806, lng:-43.987569430063324 }; 
        var marker144 = new google.maps.Marker({
            position: ubs144,
            map: map,
            title: "Centro de Saúde Jardim Leblon",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs145 = { lat: -19.80938839639889, lng: -44.0011744233109}; 
        var marker145 = new google.maps.Marker({
            position: ubs145,
            map: map,
            title: "Centro de Saúde Lagoa",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs146 = { lat:-19.79955472316555,  lng: -43.980437928602946 };
        var marker146 = new google.maps.Marker({
            position: ubs146,
            map: map,
            title: "Centro de Saúde Mantiqueira",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs147 = { lat:-19.80532227960273,  lng: -43.95785425609193}; 
        var marker147 = new google.maps.Marker({
            position: ubs147,
            map: map,
            title: "Centro de Saúde Minas Caixa",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs148 = { lat:-19.79387122210997,   lng: -43.96733074948908};
        var marker148 = new google.maps.Marker({
            position: ubs148,
            map: map,
            title: "Centro de Saúde Nova York",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs149 = { lat:-19.802384258699526,  lng: -43.98916691631617}; 
        var marker149 = new google.maps.Marker({
            position: ubs149,
            map: map,
            title: "Centro de Saúde Paraúna",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs150 = { lat: -19.81635944076821, lng: -43.99276714549054}; 
        var marker150 = new google.maps.Marker({
            position: ubs150,
            map: map,
            title: "Centro de Saúde Piratininga",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs151 = { lat:-19.814240780012955,  lng: -43.980760821091344}; 
        var marker151 = new google.maps.Marker({
            position: ubs151,
            map: map,
            title: "Centro de Saúde Rio Branco",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

         
        var ubs152 = { lat:-19.829429000154835,  lng:-43.97681802791853 };
        var marker152 = new google.maps.Marker({
            position: ubs152,
            map: map,
            title: "Centro de Saúde Santa Mônica",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs153 = { lat: -19.81778227573194,  lng: -43.95888939938781};
        var marker153 = new google.maps.Marker({
            position: ubs153,
            map: map,
            title: "Centro de Saúde Santo Antônio",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

        var ubs154 = { lat:-19.79547128349866,  lng:-43.95368437055397 }; 
        var marker154 = new google.maps.Marker({
            position: ubs154,
            map: map,
            title: "Centro de Saúde Serra Verde",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

    }
}

/*

 var ubsx = { lat:  lng: };
        var markerx = new google.maps.Marker({
            position: ubsx,
            map: map,
            title: "",
            icon: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
        });

 */