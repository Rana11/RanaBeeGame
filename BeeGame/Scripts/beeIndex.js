$(function () {

    var resetBeesColor = function () {
        var $bees = $('.bee');
        $.map($bees, function (element) {
            $(element).css('background-color', 'black');
        });
    }

    var onFinish = function () {
        if (confirm('Game over, Start another round?')) {
            location.reload();
        }
    }

    var onBeeDead = function(id) {
        var newId = 0;

        var $selectedBee = $('.bee[data-id="' + id + '"]');
        $selectedBee.remove();

        var $bees = $('.bee');
        $.map($bees, function (element) {
            $(element).attr('data-id', (newId++).toString());
        });
        
    }

    var applyAnnimationOnSelectedBee = function (data) {
        var $selectedBee = $('.bee[data-id="' + data.id + '"]');
        $selectedBee.css('background-color', 'lightpink');

        $selectedBee.fadeOut(300, function () {
            $selectedBee.fadeIn(400, function () {
                $selectedBee.html(data.pointsLeft);
            });
        });
    }

    $('#hitBtn').on('click', function () {
        $.post('/home/hit', function (data) {

            console.log(data);
            resetBeesColor();

            if (data.isDead) {
                onBeeDead(data.id);
            } else {
                applyAnnimationOnSelectedBee(data);
            }

            if (data.isFinish == true) {
                onFinish();
            }
        });
    });
});