<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$shipment = \EasyPost\Shipment::create([
    'to_address' => ['id' => 'adr_...'],
    'from_address' => ['id' => 'adr_...'],
    'parcel' => [
        'length' => 20.2,
        'width' => 10.9,
        'height' => 5,
        'weight' => 65.9
    ],
    'options' => ['print_custom_1' => 'Custom label message']
]);

echo $shipment;
