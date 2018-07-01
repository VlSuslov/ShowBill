function initFullMap(events) {
    const input = $('#place')[0];

    map = new google.maps.Map($("#map")[0], {
        zoom: 8,
        center: events[0].Position
    });

    const searchBox = new google.maps.places.SearchBox(input);
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);
    searchBox.setBounds(map.getBounds());

    searchBox.addListener('places_changed', () => {
        const places = searchBox.getPlaces();
        if (places.length == 0) {
            return;
        }

        map.setCenter(places[0].geometry.location);
    });

    for (let event of events) {
        let marker = new google.maps.Marker({
            position: event.Position,
            map: map
        });

        const info = `<div>
                    <img style="width:200px" src="${event.Photo}" />
                    <div>${event.Title}</div>
                    <div>${event.Date}</div>
                    <button class="btn btn-default" onclick="goToDetails('${event.Id}')">Details</button>
                    </div>`;

        const infowindow = new google.maps.InfoWindow({
            content: info
        });

        marker.addListener('click', function () {
            infowindow.open(map, marker);
        });

        map.addListener('bounds_changed', function () {
        });
    }
};

function initDetailsMap(position) {
    const map = new google.maps.Map($("#map")[0], {
        zoom: 4,
        center: position
    });
    let marker = new google.maps.Marker({
        position: position,
        map: map
    });
};

function goToDetails(id) {
    window.location.replace(`/Events/Details/${id}`);
}