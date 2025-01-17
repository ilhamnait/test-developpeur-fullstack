<?php
    $produits = [
        ["id" => 1, "nom" => "Chaise", "prix" => 199.99],
        ["id" => 2, "nom" => "Table", "prix" => 299.99],
        ["id" => 3, "nom" => "Stylo", "prix" => 2.50]
    ];

    function produitLePlusCher($produits) {
        // Initialisation du produit le plus cher
        $produitCher = $produits[0];
        
        // Parcourir tous les produits pour trouver celui avec le prix le plus élevé
        foreach ($produits as $produit) {
            if ($produit['prix'] > $produitCher['prix']) {
                $produitCher = $produit;
            }
        }
        
        return $produitCher['nom'];
    }

    function produitsMoinsChersQue($produits, $prixLimite) {
        $resultats = [];
        
        // Parcourir les produits et vérifier s'ils sont moins chers que la limite
        foreach ($produits as $produit) {
            if ($produit['prix'] < $prixLimite) {
                $resultats[] = $produit;
            }
        }
        
        return $resultats;
    }
    
    // Test de la fonction produitLePlusCher
    echo "Le produit le plus cher est : " . produitLePlusCher($produits) . "\n";

    // Test de la fonction produitsMoinsChersQue
    $prixLimite = 100;
    $produitsMoinsChers = produitsMoinsChersQue($produits, $prixLimite);

    echo "Produits avec un prix inférieur à $prixLimite :\n";
    foreach ($produitsMoinsChers as $produit) {
        echo "- " . $produit['nom'] . " (Prix: " . $produit['prix'] . ")\n";
    }
?>
 
