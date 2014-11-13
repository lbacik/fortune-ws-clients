<?php

require_once 'FortuneSrvSoapClient.php';

$f = new FortuneSrvSoapClient();

echo $f->getFortuneStr('debian/pl');

