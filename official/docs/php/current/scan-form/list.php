<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$scanForms = \EasyPost\ScanForm::all([
    'page_size' => 5
]);

echo $scanForms;
